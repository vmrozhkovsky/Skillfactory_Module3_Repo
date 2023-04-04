
using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        string UserName;
        byte UserAge;
        string UserHaveSkillLine;
        bool UserHaveSkill;
        double UserSkillSize;

        Console.WriteLine("Как Вас зовут?");
        UserName = Console.ReadLine();
        Console.WriteLine("Сколько Вам лет?");
        UserAge = Convert.ToByte(Console.ReadLine());
        Console.WriteLine("Имеете ли опыт программирования (Y/N)?");

        UserHaveSkillLine = Console.ReadLine();
        if (UserHaveSkillLine == "Y")
        {
            UserHaveSkill = true;
            Console.WriteLine("Каков ваш уровень (1-10)?");
            UserSkillSize = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Здравствуйте, {0}", UserName);
            Console.WriteLine("Вы мне сказали, что вас зовут {1}, Вам - {2} год и у Вас есть опыт программирования, который Вы оценили на {0}", UserSkillSize, UserName, UserAge);
            Console.WriteLine("Рад был познакомиться!");
        }
        else
        {
            UserHaveSkill = false;
            Console.WriteLine("Здравствуйте, {0}", UserName);
            Console.WriteLine("Вы мне сказали, что вас зовут {0}, Вам - {1} год и у Вас нет опыта программирования.", UserName, UserAge);
            Console.WriteLine("Рад был познакомиться!");
        }
    }
}