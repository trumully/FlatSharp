﻿/*
 * Copyright 2018 James Courtney
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

namespace FlatSharp
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// A base class that FlatBuffersNet implements to deserialize vectors. FlatBufferVetor{T} is a lazy implementation
    /// which will create a new instance for each item it returns. For cases where greedy deserialization is desired, 
    /// consider using an array or <see cref="FlatBufferCacheVector{T}"/>.
    /// </summary>
    public class FlatBufferVector<T> : IList<T>, IReadOnlyList<T>
    {
        private readonly InputBuffer memory;
        private readonly int offset;
        private readonly int itemSize;
        private readonly int count;
        private Func<InputBuffer, int, T> parseItem;

        public FlatBufferVector(
            InputBuffer memory,
            int offset,
            int itemSize,
            Func<InputBuffer, int, T> parseItem)
        {
            this.memory = memory;
            this.offset = offset;
            this.itemSize = itemSize;
            this.count = checked((int)this.memory.ReadUInt(this.offset));
            this.parseItem = parseItem;
        }

        /// <summary>
        /// Gets the item at the given index.
        /// </summary>
        public virtual T this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                checked
                {
                    if (index < 0 || index >= this.Count)
                    {
                        throw new IndexOutOfRangeException();
                    }

                    // start at offset, skip past the number of items, and then multiply item size * index.
                    return this.parseItem(
                        this.memory,
                        this.offset + sizeof(uint) + (this.itemSize * index));
                }
            }
            set
            {
                throw new NotSupportedException("FlatBufferVector does not allow mutating items.");
            }
        }

        public int Count => this.count;

        public bool IsReadOnly => true;

        public void Add(T item)
        {
            throw new NotSupportedException("FlatBufferVector does not allow adding items.");
        }

        public void Clear()
        {
            throw new NotSupportedException("FlatBufferVector does not support clearing.");
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            var count = this.Count;
            for (int i = 0; i < count; ++i)
            {
                array[arrayIndex + i] = this[i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T[] ToArray()
        {
            int count = this.count;
            T[] array = new T[count];

            for (int i = 0; i < count; ++i)
            {
                array[i] = this[i];
            }

            return array;
        }

        public IEnumerator<T> GetEnumerator()
        {
            int count = this.Count;
            for (int i = 0; i < count; ++i)
            {
                yield return this[i];
            }
        }

        public int IndexOf(T item)
        {
            int count = this.Count;
            for (int i = 0; i < count; ++i)
            {
                if (item.Equals(this[i]))
                {
                    return i;
                }
            }

            return -1;
        }

        public void Insert(int index, T item)
        {
            throw new NotSupportedException("FlatBufferVector does not support inserting.");
        }

        public bool Remove(T item)
        {
            throw new NotSupportedException("FlatBufferVector does not support removing.");
        }

        public void RemoveAt(int index)
        {
            throw new NotSupportedException("FlatBufferVector does not support removing.");
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
