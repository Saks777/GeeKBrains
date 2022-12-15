int SpeedFriendOne = 1;
int SpeedFriendTwo = 2;
int SpeedDog = 5;
int Distance = 10000;
int Friend = 1;
int count = 0;
int time;
while(Distance > 10)
{
  if (Friend == 1)
   {
     time = Distance / (SpeedFriendOne + SpeedDog);
     Friend = 2;
     Distance = Distance - (SpeedFriendOne + SpeedFriendTwo) * time;
     count = count + 1;
   }
   else if (Friend == 2)
   {
    time = Distance / (SpeedFriendTwo + SpeedDog);
     Friend = 1;
     Distance = Distance - (SpeedFriendOne + SpeedFriendTwo) * time;
     count = count + 1;
   }

}
Console.Write(count);