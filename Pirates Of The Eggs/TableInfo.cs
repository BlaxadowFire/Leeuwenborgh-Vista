using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates_Of_The_Eggs
{
    class TableInfo
    {
        public static int Table1;
        public static int Table2;
        public static int Table3;
        public static int Table4;
        public static int Table5;
        public static int Table6;
        public static int Table7;
        public static int Table8;
        public static int Table9;
        public static int Table10;
        public static int Table11;
        public static int Table12;
        public static int Table13;
        public static int Table14;
        public static int Table15;
        public static int Table16;
        public static int Table17;
        public static int Table18;
        public static int Table19;
        public static int Table20;

        public static void DynamicTable(int x)
        {
            switch (x)
            {
                case 1:
                {
                    Table1 = Table1 == 0 ? 1 : 0;
                    break;
                }
                case 2:
                {
                    Table2 = Table2 == 0 ? 1 : 0;
                        break;
                }
                case 3:
                {
                    Table3 = Table3 == 0 ? 1 : 0;
                        break;
                }
                case 4:
                {
                    Table4 = Table4 == 0 ? 1 : 0;
                        break;
                }
                case 5:
                {
                    Table5 = Table5 == 0 ? 1 : 0;
                        break;
                }
                case 6:
                {
                    Table6 = Table6 == 0 ? 1 : 0;
                        break;
                }
                case 7:
                {
                    Table7 = Table7 == 0 ? 1 : 0;
                        break;
                }
                case 8:
                {
                    Table8 = Table8 == 0 ? 1 : 0;
                        break;
                }
                case 9:
                {
                    Table9 = Table9 == 0 ? 1 : 0;
                        break;
                }
                case 10:
                {
                    Table10 = Table10 == 0 ? 1 : 0;
                        break;
                }
                case 11:
                {
                    Table11 = Table11 == 0 ? 1 : 0;
                        break;
                }
                case 12:
                {
                    Table12 = Table12 == 0 ? 1 : 0;
                        break;
                }
                case 13:
                {
                    Table13 = Table13 == 0 ? 1 : 0;
                        break;
                }
                case 14:
                {
                    Table14 = Table14 == 0 ? 1 : 0;
                        break;
                }
                case 15:
                {
                    Table15 = Table15 == 0 ? 1 : 0;
                        break;
                }
                case 16:
                {
                    Table16 = Table16 == 0 ? 1 : 0;
                        break;
                }
                case 17:
                {
                    Table17 = Table17 == 0 ? 1 : 0;
                        break;
                }
                case 18:
                {
                    Table18 = Table18 == 0 ? 1 : 0;
                        break;
                }
                case 19:
                {
                    Table19 = Table19 == 0 ? 1 : 0;
                        break;
                }
                case 20:
                {
                    Table20 = Table20 == 0 ? 1 : 0;
                        break;
                }
            }
        }

        public static int DynamicTableRead(int x)
        {
            switch (x)
            {
                case 1:
                {
                    return Table1;
                }
            case 2:
                {
                    return Table2;
                }
            case 3:
                {
                    return Table3;
                }
            case 4:
                {
                    return Table4;
                }
            case 5:
                {
                    return Table5;
                }
            case 6:
                {
                    return Table6;
                }
            case 7:
                {
                    return Table7;
                }
            case 8:
                {
                    return Table8;
                }
            case 9:
                {
                    return Table9;
                }
            case 10:
                {
                    return Table10;
                }
            case 11:
                {
                    return Table11;
                }
            case 12:
                {
                    return Table12;
                }
            case 13:
                {
                    return Table13;
                }
            case 14:
                {
                    return Table14;
                }
            case 15:
                {
                    return Table15;
                }
            case 16:
                {
                    return Table16;
                }
            case 17:
                {
                    return Table17;
                }
            case 18:
                {
                    return Table18;
                }
            case 19:
                {
                    return Table19;
                }
            case 20:
                {
                    return Table20;
                }
            }
            return 0;
        }
    }
}
