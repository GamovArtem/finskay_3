Console.Write("Ввидите дату вашего рождения: ");
string[] date = Console.ReadLine().Split(' ', '.', ',', '-','/') ;  // Ввод массив с датой рождения
string? resote;
int[] months = {31,28,31,30,31,30,31,31,30,31,30,31};           // кол.дней в месяце с января

if (Convert.ToInt32(date[2]) % 4 == 0) months[1] = 29; // в случае высокосного года

string[] sing =              // массив с знаками
{"Водолей","Рыбы","Овен","Телец","Близнецы","Рак","Лев","Дева","Весы","Скорпион","Стрелец","Козерог"};

int[,] singDate =            // массив с датами знакам
{{ 18,1},{ 20,2},{ 19,3},{ 20,4},{ 20,5},{ 22,6},{ 22,7},{ 22,8},{ 22,9},{ 21,10},{ 21,11},{ 19,0}};

int month = Convert.ToInt32(date[1]) - 2; // месяц рождения
if (month < 13 && Convert.ToInt32(date[0]) <= months[month + 1])
{
    if (singDate[month, 0] < 20 && month == 1) 
    { resote = "Козерог"; }
    else if (singDate[month, 0] > Convert.ToInt32(date[0])) 
    { resote = sing[month]; }
    else 
    { resote = sing[month + 1]; }
}
else 
{ resote = "Маслов?" ;}
    
Console.WriteLine("Вы " + resote);
