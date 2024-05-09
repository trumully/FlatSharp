using FlatSharp.Internal;

namespace FlatSharpEndToEndTests.ToString;

[TestClass]
class ToStringTests
{
    [TestMethod]
    [DynamicData(nameof(DynamicDataHelper.DeserializationModes), typeof(DynamicDataHelper))]
    public void Monster_ToString(FlatBufferDeserializationOption option)
    {
        Monster monster = new Monster
        {
            Color = Color.Green,
            Equipped = new Equipped(new Weapon { Damage = 100, Name = "Master sword" }),
            Friendly = true,
            HP = 932,
            Inventory = new byte[] { 1, 2, 3, 4, 5, },
            Mana = 32,
            Name = "Link",
            Pos = new Vec3 { X = 1.1f, Y = 3.2f, Z = 2.6f },
            Weapons = new List<Weapon> { new Weapon { Damage = 6, Name = "Hook shot" }, new Weapon { Name = "Bow and Arrow", Damage = 37 } },
            Path = new Vec3[]
            {
                new Vec3 { X = 1f, Y = 2f, Z = 3f },
                new Vec3 { X = 4f, Y = 5f, Z = 6f },
                new Vec3 { X = 7f, Y = 8f, Z = 9f }
            }
        };

        int maxSize = Monster.Serializer.GetMaxSize(monster);

        byte[] buffer = new byte[maxSize];
        int bytesWritten = Monster.Serializer.Write(buffer, monster);

        Monster parsedMonster = Monster.Serializer.Parse(buffer, option);

        Assert.AreEqual("Equipped { Weapon { Name = Master sword, Damage = 100 } }", parsedMonster.Equipped.ToString());
        Assert.AreEqual("Weapon { Name = Master sword, Damage = 100 }", parsedMonster.Equipped.Weapon.ToString());
        Assert.AreEqual("Vec3 { X = 1.1, Y = 3.2, Z = 2.6 }", parsedMonster.Pos.ToString());
        Assert.AreEqual("Weapon { Name = Hook shot, Damage = 6 }", parsedMonster.Weapons[0].ToString());
        Assert.AreEqual("Weapon { Name = Bow and Arrow, Damage = 37 }", parsedMonster.Weapons[1].ToString());
        Assert.AreEqual("Vec3 { X = 1, Y = 2, Z = 3 }", parsedMonster.Path[0].ToString());
        Assert.AreEqual("Vec3 { X = 4, Y = 5, Z = 6 }", parsedMonster.Path[1].ToString());
        Assert.AreEqual("Vec3 { X = 7, Y = 8, Z = 9 }", parsedMonster.Path[2].ToString());
    }
}