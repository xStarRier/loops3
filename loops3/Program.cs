//Lag en while-løkke som printer ut "Runde nummer:" + et tall som øker med 1 per runde, så lenge rundetelleren er mindre enn 10
//Eks:Runde nr 1 Runde nr 2 Runde nr 3


bool isRunning = true;
int i = 0;
while (isRunning == true)
{
    if(i > 9){

         isRunning = false;
    }
    Console.WriteLine("Round Num "  +  i);
    i++;
}

