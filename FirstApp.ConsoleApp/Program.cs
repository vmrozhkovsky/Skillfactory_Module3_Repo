// See https://aka.ms/new-console-template for more information
Console.WriteLine("Как Вас зовут?");
string name = Console.ReadLine();
Console.WriteLine("Сколько Вам лет?");
string age = Console.ReadLine();
Console.WriteLine("Чем Вы занимаетесь на работе?");
string work = Console.ReadLine();
Console.WriteLine("Здравствуйте, {0}", name);
Console.WriteLine("Вы мне сказали, что вас зовут {1}, Вам - {2} год и что на работе вы занимаетесь {0}", work, name, age);
Console.WriteLine("Рад был познакомиться!");
