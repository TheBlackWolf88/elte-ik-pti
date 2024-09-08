using HydroCircle;
namespace HydroCircleTest;

[TestClass]
public class HydroCircleTest
{
    [TestMethod]
    public void TestZeroArea()
    {
        Atmosphere atmo = new Atmosphere(0);
        Assert.IsNotNull(atmo); 
        Assert.AreEqual(false, atmo.MaxWaterVolume(out _, out _));
    }

    [TestMethod]
    public void TestAreaCtrAdd()
    {
        Atmosphere atmo = new Atmosphere(0);
        Area testArea = new Area(atmo, "test", 12, null);
        testArea.ChangeType(new Plains(testArea));
        Assert.AreEqual("Area test; Type: Plains; Water volume: 12", testArea.ToString());
        Assert.AreEqual(0, atmo.areas.Count);
        atmo.AddArea(testArea);
        Assert.AreEqual(1, atmo.areas.Count);
        Assert.AreEqual(true, atmo.areas.Contains(testArea));
        Assert.ThrowsException<Exception>(() => atmo.AddArea(testArea));
    }

    [TestMethod]
    public void TestAreaVisit()
    {
        Atmosphere atmo = new Atmosphere(0);
        Area testArea1 = new Area(atmo, "test1", 12, null);
        testArea1.ChangeType(new Plains(testArea1));
        atmo.AddArea(testArea1);

        atmo.VisitAreas(Sunny.Instance());
        Assert.AreEqual(9, testArea1.wv);
        atmo.VisitAreas(Cloudy.Instance());
        Assert.AreEqual(10, testArea1.wv);
        atmo.VisitAreas(Rainy.Instance());
        Assert.AreEqual(15, testArea1.wv);
        
        Area testArea2 = new Area(atmo, "test2", 30, null);
        testArea2.ChangeType(new Green(testArea2));
        atmo.AddArea(testArea2);

        atmo.VisitAreas(Sunny.Instance());
        Assert.AreEqual(24, testArea2.wv);
        atmo.VisitAreas(Cloudy.Instance());
        Assert.AreEqual(26, testArea2.wv);
        atmo.VisitAreas(Rainy.Instance());
        Assert.AreEqual(36, testArea2.wv);


        Area testArea3 = new Area(atmo, "test2", 70, null);
        testArea3.ChangeType(new Swamp(testArea3));
        atmo.AddArea(testArea3);

        atmo.VisitAreas(Sunny.Instance());
        Assert.AreEqual(60, testArea3.wv);
        atmo.VisitAreas(Cloudy.Instance());
        Assert.AreEqual(63, testArea3.wv);
        atmo.VisitAreas(Rainy.Instance());
        Assert.AreEqual(78, testArea3.wv);
    }

    [TestMethod]
    public void TestPlainsGreen() {
        Atmosphere atmo = new Atmosphere(0);
        Area testArea = new Area(atmo, "test", 12, null);
        testArea.ChangeType(new Plains(testArea));
        testArea.ReactToWeather(Rainy.Instance());
        Assert.AreEqual(17, testArea.wv);
        Assert.AreEqual("Area test; Type: Green; Water volume: 17", testArea.ToString());
    }
    [TestMethod]
    public void TestGreenPlains() {
        Atmosphere atmo = new Atmosphere(0);
        Area testArea = new Area(atmo, "test", 20, null);
        testArea.ChangeType(new Green(testArea));
        testArea.ReactToWeather(Sunny.Instance());
        Assert.AreEqual(14, testArea.wv);
        Assert.AreEqual("Area test; Type: Plains; Water volume: 14", testArea.ToString());
    }
    [TestMethod]
    public void TestGreenSwamp() {
        Atmosphere atmo = new Atmosphere(0);
        Area testArea = new Area(atmo, "test", 45, null);
        testArea.ChangeType(new Green(testArea));
        testArea.ReactToWeather(Rainy.Instance());
        Assert.AreEqual(55, testArea.wv);
        Assert.AreEqual("Area test; Type: Swamp; Water volume: 55", testArea.ToString());
    }
    [TestMethod]
    public void TestSwampGreen() {
        Atmosphere atmo = new Atmosphere(0);
        Area testArea = new Area(atmo, "test", 55, null);
        testArea.ChangeType(new Swamp(testArea));
        testArea.ReactToWeather(Sunny.Instance());
        Assert.AreEqual(45, testArea.wv);
        Assert.AreEqual("Area test; Type: Green; Water volume: 45", testArea.ToString());
    }

    [TestMethod]
    public void TestMultipleAreas()
    {
        Atmosphere atmo = new Atmosphere(0);
        string[] names = { "ForestArea", "MountainArea", "RiverArea", "ValleyArea", "DesertArea", "JungleArea" };
        int[] wvs = { 30, 12, 60, 25, 10, 35 };
        char[] types = { 'g', 'p', 's', 'g', 'p', 'g' };

        for (int i = 0; i < names.Length; i++)
        {
            Area area = new Area(atmo, names[i], wvs[i], null);
            switch (types[i])
            {
                case 'p': area.ChangeType(new Plains(area)); break;
                case 'g': area.ChangeType(new Green(area)); break;
                case 's': area.ChangeType(new Swamp(area)); break;
            }
            atmo.AddArea(area);
        }

        Weather[] wArr = { Cloudy.Instance(), Sunny.Instance(), Rainy.Instance(), Rainy.Instance(), Sunny.Instance(), Cloudy.Instance(), Sunny.Instance(), Rainy.Instance(), Sunny.Instance(), Cloudy.Instance() };
        for (int i = 0; i < 10; i++)
        {
            atmo.VisitAreas(wArr[i]);
        }
        Assert.AreEqual(true, atmo.MaxWaterVolume(out int wv, out Area? a));
        Assert.AreEqual(74, wv);
        Area testArea = new Area(atmo, "RiverArea", 74, null);
        testArea.ChangeType(new Swamp(testArea));
        Assert.AreEqual(testArea.ToString(), a!.ToString());
    }

    [TestMethod]
    public void TestWeather()
    {
        Atmosphere atmo = new Atmosphere(10);
        Assert.AreEqual(atmo.Weather(), Sunny.Instance());
        atmo.IncreaseHumidity(70);
        Assert.AreEqual(atmo.Weather(), Rainy.Instance());
        bool voltRain = false;
        bool voltCloud = false;
        //humidity is 30
        atmo.IncreaseHumidity(20);
        while (!voltRain || !voltCloud)
        {
            Weather w = atmo.Weather();
            if (w == Rainy.Instance())
            {
                voltRain = true;
                atmo.IncreaseHumidity(20);
            }
            else if (w == Cloudy.Instance())
            {
                voltCloud = true;
            }
        }
        Assert.AreEqual(true, voltCloud);
        Assert.AreEqual(true, voltRain);
    }

}
