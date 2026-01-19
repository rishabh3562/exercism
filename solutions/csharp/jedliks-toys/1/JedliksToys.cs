class RemoteControlCar
{

    public int travel=0;
    public int tcost=20;
    public int drain=1;
    public int battery=100;

    
    public static RemoteControlCar Buy()
    {
        RemoteControlCar car = new RemoteControlCar();
        car.tcost=20;
        car.drain=1;
        return car;
    }

    public string DistanceDisplay()
    {
        return ("Driven "+travel+" meters");
    }

    public string BatteryDisplay()
    { if(battery<=0){

        return ("Battery empty");
    }
        return ("Battery at "+battery+"%");
    }

    public void Drive()
    {
        
        if(battery>0){
travel=travel+tcost;
        battery=battery-drain;
        }
    }
}
