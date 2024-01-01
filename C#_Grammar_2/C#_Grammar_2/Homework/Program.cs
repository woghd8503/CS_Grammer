using System;
using System.Reflection;
using System.Text;

namespace Homework
{
    public class Some
    {
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            Type type = this.GetType();

            AddFieldInfoToStringBuilder(stringBuilder, type.GetFields(BindingFlags.Public | BindingFlags.Instance));
            AddFieldInfoToStringBuilder(stringBuilder, type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance));

            return stringBuilder.ToString();
        }

        private void AddFieldInfoToStringBuilder(StringBuilder stringBuilder, FieldInfo[] fields)
        {
            foreach (var field in fields)
            {
                stringBuilder.AppendLine($"{(field.IsPublic ? "public" : "private")} {field.Name}: {field.GetValue(this)}");
            }
        }
    }

    public class James : Some
    {
        public string name = "박재홍";
        public int age = 33;
        public int weight = 99;
        private string phoneNum = "01062048503";
        private string job = "entrepreneur";
    }

    public class JamesWife : Some
    {
        public string name = "김이쁜";
        public int age = 26;
        public int weight = 48;
        private string phoneNum = "01010041004";
        private string job = "James 현모양처";
    }

    public class Homework
    {
        public static void Main()
        {
            James james = new James();
            JamesWife jamesWife = new JamesWife();

            Console.WriteLine(james.ToString());
            Console.WriteLine(jamesWife.ToString());
        }
    }
}