using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyAlert.Enum
{
    public enum Currency
    {
        [Name("亚拉戈诗学神典石"), ItemID(28), DefaultThreshold(1400), Category("战斗")]
        TomestoneOfPoetics,
        [Name("亚拉戈经典神典石"), ItemID(42), DefaultThreshold(1700), Category("战斗")]
        TomestoneOfAphorism,
        [Name("亚拉戈天文神典石"), ItemID(43), DefaultThreshold(1700), Category("战斗")]
        TomestoneOfAstronomy,

        [Name("黑涡团军票"),  ItemID(20), DefaultThreshold(75000), Category("共通")]
        StormSeal,
        [Name("双蛇党军票"), ItemID(21), DefaultThreshold(75000), Category("共通")]
        SerpentSeal,
        [Name("恒辉队军票"), ItemID(22), DefaultThreshold(75000), Category("共通")]
        FlameSeal,

        [Name("狼印战绩"), ItemID(25), DefaultThreshold(18000), Category("战斗")]
        WolfMark,
        [Name("战利水晶"), ItemID(36656), DefaultThreshold(18000), Category("战斗")]
        TrophyCrystal,

        [Name("同盟徽章"), ItemID(27), DefaultThreshold(3500), Category("战斗")]
        AlliedSeal,
        [Name("兵团徽章"), ItemID(10307), DefaultThreshold(3500), Category("战斗")]
        CenturioSeal,
        [Name("怪物狩猎的战利品"), ItemID(26533), DefaultThreshold(3500), Category("战斗")]
        SackOfNut,
        [Name("双色宝石"), ItemID(26807), DefaultThreshold(800), Category("战斗")]
        BicolorGemstone,

        [Name("巧手白票"), ItemID(25199), DefaultThreshold(1500), Category("其他")]
        WhiteCraftersScrip,
        [Name("巧手紫票"), ItemID(33913), DefaultThreshold(1500), Category("其他")]
        PurpleCraftersScrip,
        [Name("大地白票"), ItemID(25200), DefaultThreshold(1500), Category("其他")]
        WhiteGatherersScrip,
        [Name("大地紫票"), ItemID(33914), DefaultThreshold(1500), Category("其他")]
        PurpleGatherersScrip,
        [Name("天穹街振兴票"), ItemID(28063), DefaultThreshold(7500), Category("其他")]
        SkybuildersScrip
    }
}
