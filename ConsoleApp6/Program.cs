
using Microsoft.Win32;

namespace ConsoleApp6
{
    class Program
    {
        public static void Main(string[] args)
        {
            string subKeyName = "CustomSubKeyForCurrentUser";
            Console.WriteLine("Registry");
            RegistryKey CurrentUser = Registry.CurrentUser;
            RegistryKey newSubKey = CurrentUser.CreateSubKey(subKeyName);

            newSubKey.SetValue("isTestValueSet", "true");
            newSubKey.Close();
            CurrentUser.Close();

            Console.WriteLine("Press to continue");
            Console.ReadLine();
            CurrentUser= Registry.CurrentUser;
            newSubKey = CurrentUser.OpenSubKey(subKeyName,true);

            newSubKey.DeleteValue("isTestValueSet");
            CurrentUser.DeleteSubKey(subKeyName);

            CurrentUser.Close();

        }

        class ForCleaning
        {
            public ForCleaning()
            {

            }
            ~ForCleaning()
            {

            }
        }
    }
}