Console.WriteLine("Massive I.cs");
int[] before = new int[]{1,2,-3,4,-5,-6,7,8,9,-10, -11,-12,13};
Console.WriteLine(string.Join(' ',before));

for (int i = 0; i < before.Length; i++)
{
    if (before[i]<0){
        before[i]=3;
    }
}
int[] after = before;


Console.WriteLine(string.Join(' ',after));


Console.WriteLine ("Мassive E.js");

// -------------------------------------------------------------------------

int[] fruite = new int[]{1,2,-3,4,-5,-6,7,8,90,-10, -11,-12,13};
int maxim=fruite.Max();
int j=Array.IndexOf(fruite,maxim);

(fruite[0],fruite[j])=(fruite[j],fruite[0]);
Console.WriteLine(string.Join(' ',fruite));

// -------------------------------------------------------------------------
char[] Eroor=new char[]{'!','-',',','_','.',';',':'};
string[] ustal = new string[]{"МДК!","Слово","Смысл!","Жизнь","Земля","Планета!","Красота","Округ!","Система!","Игорь!",
"САО","Продуктивность!","Орёл","Донецк!","Это!","Не бойся","***","-Боль","А","С"};
int calc(String str) {
    int result=0;

    foreach (char Prepin in str){
       if (Eroor.Contains(Prepin)) {
        result++;
       }         
    }

    return result;
}

int result = 0;
 foreach (string str in ustal){
    Console.WriteLine("{0}:{1}",str,calc(str));
    result+=calc(str);
 }

Console.WriteLine(result);
