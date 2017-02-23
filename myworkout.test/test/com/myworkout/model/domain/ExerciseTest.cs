using System;
using NUnit.Framework;

using myworkout.model.domain;

namespace test.com.myworkout.model.domain
{
	[TestFixture]
	public class ExerciseTest
	{
		Exercise ex;
		Exercise ex2;
		Exercise exFail;
		string name;
		double weight;
		int sets;
		int reps;
		int lastReps;

		[SetUp]
		public void setUp()
		{
			name = "BenchPress";
			weight = 100.50;
			sets = 3;
			reps = 5;
			lastReps = 8;
			ex = new Exercise(name, 1, weight, sets, reps, lastReps);
			ex2 = new Exercise(name, 1, weight, sets, reps, lastReps);
			exFail = new Exercise();
		}



		//Test valid exercise
		[TestCase]
		public void validTest()
		{
			Console.WriteLine("Exercise : Starting Valid Test");
			Assert.True(ex.validate());
			Console.WriteLine("Valid Test Passed");
		}


		//Test Valid when it should fail
		[TestCase]
		public void validateFailTest()
		{
			Console.WriteLine("Exercise : Starting Fail Valid Test");
			Assert.False(exFail.validate());
			Console.WriteLine("Valid Fail Test Passed");

		}

		//Test Equals
		[TestCase]
		public void equalsTest()
		{
			Console.WriteLine("Exercise : Starting Equals Test");
			Assert.True(ex.Equals(ex2));
			Console.WriteLine("Equals Test Passed");
		}

		//Test Equals when it should fail
		[TestCase]
		public void equalsFailTest()
		{
			Console.WriteLine("Exercise : Starting Equals Fail Test");
			Assert.False(ex.Equals(exFail));
			Console.WriteLine("Equals Fail Test Passed");

		}

		//Test toString method
		[TestCase]
		public void toStringTest()
		{
			Console.WriteLine("Exercise : Starting toString Test");
			string str = ex.ToString();
			Assert.True(str != null);
			Console.WriteLine(str);
			Console.WriteLine("ToString Test Passed");
		}

		//Test getHashCode Method
		[TestCase]
		public void getHashCodeTest()
		{
			Console.WriteLine("Exercise : Starting getHashCode Test");
			int hashCode = ex.GetHashCode();
			Assert.True(hashCode != 0);
			Console.WriteLine(hashCode);
			Console.WriteLine("GetHashCode Test Passed");
		}


	}//End of Class
}//End of namespace