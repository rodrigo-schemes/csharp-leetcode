namespace LeetCode.Easy.Designs;

public class ParkingSystem
{
    private readonly Dictionary<int, int> _parking = new();
    
    public ParkingSystem(int big, int medium, int small) {
        _parking.Add(1, big);
        _parking.Add(2, medium);
        _parking.Add(3, small);
    }
    
    public bool AddCar(int carType)
    {
        var qtd = _parking.GetValueOrDefault(carType);
        if (qtd == 0) return false;
        
        _parking[carType] = qtd - 1;
        return true;
    }
}
