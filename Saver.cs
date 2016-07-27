/*
 * Created by SharpDevelop.
 * User: user
 * Date: 08.10.2013
 * Time: 2:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Collections.Generic;

namespace Tetris
{
	public static class Saver
	{
		public static string FileName="tetris.sav";
		
		public static HighTimesList HighTimes=new HighTimesList();
		public static HighScoresList HighScores=new HighScoresList();
		
		public static void Save(TetrisSave s)
		{
			bool added=false;
			if(HighScores.CanAdd(s))
			{ HighScores.Add(s); added=true; }
			if(HighTimes.CanAdd(s))
			{ HighTimes.Add(s); added=true; }
			
			if(!added) return;
			
			using(FileStream fs=new FileStream(FileName, FileMode.Create, FileAccess.Write))
			using(BinaryWriter bw=new BinaryWriter(fs))
			{
				for(int i=0; i<10; ++i)
				{
					bw.Write(HighScores[i].UserName);
					bw.Write(HighScores[i].Score);
					bw.Write(HighScores[i].GameDuration.Ticks);
					bw.Write(HighScores[i].GameEnded.Ticks);
				}
				for(int i=0; i<10; ++i)
				{
					bw.Write(HighTimes[i].UserName);
					bw.Write(HighTimes[i].Score);
					bw.Write(HighTimes[i].GameDuration.Ticks);
					bw.Write(HighTimes[i].GameEnded.Ticks);
				}
			}
		}
		
		public static void Load()
		{
			using(FileStream fs=new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite))
			using(BinaryReader br=new BinaryReader(fs))
			{
				List<TetrisSave> loaded=new List<TetrisSave>();
				while(br.PeekChar()!=-1)
				{
					TetrisSave sv=new TetrisSave();
					sv.UserName=br.ReadString();
					sv.Score=br.ReadInt32();
					sv.GameDuration=new TimeSpan(br.ReadInt64());
					sv.GameEnded=new DateTime(br.ReadInt64());
					loaded.Add(sv);
				}
				
				while(loaded.Count<20)
				{
					loaded.Add(new TetrisSave("---", 0, new TimeSpan(0)));
				}
				
				TetrisSave[] sc=new TetrisSave[10], tm=new TetrisSave[10];
				for(int i=0; i<10; ++i)
					sc[i]=loaded[i];
				for(int i=0; i<10; ++i)
					tm[i]=loaded[10+i];
				
				for(int i=0; i<10; ++i)
					System.Diagnostics.Trace.WriteLine(tm[i].ToString());
				
				HighScores.Write(sc);
				HighTimes.Write(tm);
				
			}
		}
	}
	
	public struct TetrisSave
	{
		public string UserName;
		public int Score;
		public DateTime GameEnded;
		public TimeSpan GameDuration;
		
		public TetrisSave(string uname, int sc, TimeSpan dur)
		{
			UserName=uname; Score=sc; GameDuration=dur; GameEnded=DateTime.Now;
		}
		
		public override string ToString()
		{
			return string.Format("[TetrisSave UserName={0}, Score={1}, GameEnded={2}, GameDuration={3}]", UserName, Score, GameEnded, GameDuration);
		}

	}
	
	public abstract class SavesList
	{
		protected TetrisSave[] Saves;
		
		public TetrisSave this[int index]
		{
			get { return Saves[index]; }
			set { Saves[index]=value; }
		}
		
		
		public SavesList()
		{
			Saves=new TetrisSave[10];
			for(int i=0; i<10; i++)
			{
				Saves[i]=new TetrisSave("---", 0, new TimeSpan(0));
				Saves[i].UserName="---";
				Saves[i].GameEnded=new DateTime(0);
			}
		}
		
		
		public void Write(TetrisSave[] svs)
		{
			for(int i=0; i<10; i++)
				Saves[i]=svs[i];
			Sort();
		}
		
		public abstract void Add(TetrisSave s);
		public abstract bool CanAdd(TetrisSave s);
		protected abstract void Sort();
	}
	
	public sealed class HighScoresList: SavesList
	{
		public HighScoresList(): base() {}
		
		
		protected override void Sort()
		{
			for(int i=0; i<10; i++)
			{
				int maxInd=i;
				for(int j=i; j<10; j++)
				{
					if(Saves[j].Score>Saves[maxInd].Score)
					{
						maxInd=j;
					}
				}
				TetrisSave tmp=Saves[maxInd];
				Saves[maxInd]=Saves[i];
				Saves[i]=tmp;
			}
		}
		
		public override bool CanAdd(TetrisSave s)
		{
			Sort();
			return Saves[9].Score<s.Score;
		}
		public override void Add(TetrisSave s)
		{
			int i;
			for(i=9; i>=1; --i)
			{
				if(Saves[i-1].Score>=s.Score)
				{
					break;
				}
				Saves[i]=Saves[i-1];
			}
			if(Saves[0].Score>s.Score)
				Saves[i]=s;
			else
				Saves[0]=s;
		}
	}
	
	
	public sealed class HighTimesList: SavesList
	{
		public HighTimesList(): base() {}
		
		
		protected override void Sort() 
		{
			for(int i=0; i<10; i++)
			{
				int maxInd=i;
				for(int j=i; j<10; j++)
				{
					if(Saves[j].GameDuration>Saves[maxInd].GameDuration)
					{
						maxInd=j;
					}
				}
				TetrisSave tmp=Saves[maxInd];
				Saves[maxInd]=Saves[i];
				Saves[i]=tmp;
			}
		}
		
		public override bool CanAdd(TetrisSave s)
		{
			Sort();
			return Saves[9].GameDuration<s.GameDuration;
		}
		public override void Add(TetrisSave s)
		{
			int i;
			for(i=9; i>=1; --i)
			{
				if(Saves[i-1].GameDuration>=s.GameDuration)
				{
					break;
				}
				Saves[i]=Saves[i-1];
			}
			if(Saves[0].GameDuration>s.GameDuration)
				Saves[i]=s;
			else
				Saves[0]=s;
		}
	}
}
