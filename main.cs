using System;

class MainClass {

 public static void Ex03 (float num1, float num2){
   float soma;
   soma= num1 + num2;
   Console.WriteLine("A soma é: {0} ", soma);
 }
 public static void Ex04 (float nota1, float nota2, float nota3, float nota4) {
   float media;
   media= ((nota1 + nota2 + nota3 + nota4)/4);

   Console.WriteLine("A media bimestral é: {0} ", media);

   }
 

  public static void Main () {
   // Ex03
    float num1, num2;

    Console.WriteLine ("Digite o primeiro numero:");
    num1= float.Parse(Console.ReadLine());
    Console.WriteLine ("Digite o segundo numero:");
    num2=float.Parse(Console.ReadLine());

   Ex03(num1,num2);

   //Ex04
   float nota1, nota2, nota3, nota4;
   Console.WriteLine("Digite a primeira nota: ");
   nota1= float.Parse(Console.ReadLine());
   Console.WriteLine("Digite a segunda nota: ");
   nota2= float.Parse(Console.ReadLine());
   Console.WriteLine("Digite a terceira nota: ");
   nota3= float.Parse(Console.ReadLine());
   Console.WriteLine("Digite a quarta nota: "); 
   nota4= float.Parse(Console.ReadLine());

   Ex04(nota1,nota2,nota3,nota4);
  






   

  }
}