using Model;
using Controller;
using RaceSim;
//using WPF_App;

Competition c1 = new Competition();

//Data.Initialize(c1);

//Track data = Data.NextRace();

//IParticipant[] users = Data.CurrentRace.Participants.ToArray();

//Visualization.DrawTrack(Data.CurrentRace.Track, users);
//Console.WriteLine(Data.CurrentRace.Track.Name);

Visualization.Initialize();

for (; ; )
{
	Thread.Sleep(100);
}
