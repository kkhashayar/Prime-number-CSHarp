// See https://aka.ms/new-console-template for more information


static void IsPrime(int number){

    
try{


    if(number != 0){
        if(number % 2 == 1){
            Console.WriteLine("Number {0} is Prime", number);
        }else{
            Console.WriteLine("Number {0} is not Prime", number);
        }

    }else{
        Console.WriteLine("Input cant be zero");
    }

}catch(Exception Err){
    Console.WriteLine(Err.ToString());
}
}

IsPrime(-1);

