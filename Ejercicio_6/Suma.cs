class Suma{
    public int nums;
    public int acumulador;
    public int suma;
    public void OPsuma(){
    acumulador=1;
        do{
        Console.WriteLine("Ingrese el "+acumulador+" número");
        acumulador++;
        nums=Convert.ToInt32(Console.ReadLine());
        suma=suma+nums;
        }while(nums!=0);
        Console.WriteLine("El resultado de la suma es: "+suma);
    }
}