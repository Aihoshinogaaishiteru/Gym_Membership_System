using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Membership_System_wDesign
{
    internal class MembersInfo
    {

        public static int[] id = new int[50];
        public static string[] fName = new string[50];
        public static string[] mName = new string[50];
        public static string[] lName = new string[50];
        public static string[] emailAdress = new string[50];
        public static DateTime[] birthDate = new DateTime[50];
        public static string[] gender = new string[50];
        public static string[] address = new string[50];
        public static double[] weight = new double[50];
        public static double[] height = new double[50];
        public static string[] subs = new string[50];
        public static string[] contactNum = new string[50];
        public static int cellClickIdHolder;
        public static bool cellCLickedChecker = false;
        public static int idCounter = 501;
        public static int indexCounter = 0;



        public static int[] memberId = new int[50];
        public static string[] memberName = new string[50];
        public static double[] change = new double[50];
        public static double totalRevenue = 0;

        public static DateTime[] startDate = new DateTime[50];
        public static DateTime[] endDate = new DateTime[50];
        public static double[] price = new double[50];

    }
}
