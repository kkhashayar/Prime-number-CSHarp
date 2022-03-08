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
Console.Clear(); 
for(int i = 0; i<200; i++){
    IsPrime(i);
}
