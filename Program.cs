internal class Program
{
    private static void Main(string[] args)
    {
        int floorBlock = 0, floor = 0, floorMax = 0; // номер блока, номер этажа, максимальный номер комнаты в блоке
        Console.WriteLine("Введите номер комнаты");
        int floorNumber = Convert.ToInt32(Console.ReadLine());
        while (floorMax < floorNumber) // отсчитываем комнаты блоками по N*N штук в каждой итерации, пока искомый номер не окажется внутри
        {
            floorBlock++; // порядковый номер блока квартир, который равен количеству квартир в блоке 
            floor += floorBlock; // номер последнего этажа в блоке
            floorMax += floorBlock * floorBlock;
        }
        // от последнего этажа отсчитываем вниз целые этажи до этажа с искомой квартирой
        floor -= (floorMax - floorNumber) / floorBlock; 
        // возвращаем номер этажа и порядковый номер комнаты
        Console.WriteLine($"Номер этажа = {floor}, номер комнаты = {floorBlock - (floorMax - floorNumber) % floorBlock}"); 
    }
}