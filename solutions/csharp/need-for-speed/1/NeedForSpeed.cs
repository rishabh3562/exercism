class RemoteControlCar
{
    
    // TODO: define the constructor for the 'RemoteControlCar' class
   public int speed {get;set;}
    public int travel=0;
   public int batteryDrain {get;set;}
   public int battery=100;
    
    
    public RemoteControlCar(int speed,int batteryDrain){
speed=speed;

        this.batteryDrain=batteryDrain;
        this.speed= speed;
        
    
    

        
    }

    public  bool BatteryDrained()
    { 
        
        if(battery<batteryDrain){
            return true;
        }
        return false;
    }

    public int DistanceDriven()
    {
        return travel;
    }

    public void Drive()
    {  if(battery<batteryDrain){
      return;    
        }
      else{
          travel= travel+speed;
          battery=battery-batteryDrain;
      }
    }

    public static RemoteControlCar Nitro()
    {
        // travel=travel+50;
        // battery=battery-4;


        RemoteControlCar car = new RemoteControlCar(50,4);
        return car;
    }
}

class RaceTrack
{
    // TODO: define the constructor for the 'RaceTrack' class
    public int distance;
    public RaceTrack(int track){
        distance=track;
    Console.WriteLine("Racetrack");
}
   public bool TryFinishTrack(RemoteControlCar car)
{
    while (!car.BatteryDrained())
    {
        car.Drive();

        if (car.DistanceDriven() >= distance)
            return true;
    }

    return false;
}
}
