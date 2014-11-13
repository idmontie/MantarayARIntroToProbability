using System;
using UnityEngine;


public class Lesson4 : MonoBehaviour 
{
	Slides slides = null;
	
	void Start ()
	{
		Assets assets = Assets.GetInstance();
		slides = new Slides("Lesson4");

		slides.Add(new Slide(
			"Exercise 1: Discovering Probability\n\nIn this exercise, we will be traveling to different sections of the lake to find the most likely location of the oil spill!\n" +
			"\n" +
			"Let's move to the Bay Area!"
		));
		
		// --------------------- Experience Slide ---------------- // 
		Slide arSlide = new Slide(
			"Point your device at Bay Area."
		);
		
		FishExperience e = new FishExperience(typeof(FishBehavior), arSlide);
		e.SetTarget(GameObject.Find (assets.BayArea));
		e.AddGameObject(assets.RandomHealthyFish());
		e.AddGameObject(assets.RandomHealthyFish());
		e.AddGameObject(assets.RandomHealthyFish());
		e.AddGameObject(assets.RandomHealthyFish());
		e.AddGameObject(assets.RandomHealthyFish());
		e.AddGameObject(assets.RandomSickFish());
		e.AddGameObject(assets.RandomSickFish());
		e.AddGameObject(assets.RandomSickFish());
		e.AddGameObject(assets.RandomSickFish());
		e.AddGameObject(assets.RandomSickFish());
		e.SetTotalNumberOfFish (10);
		
		arSlide.AttachExperience(e);
		
		slides.Add(arSlide);
		// -------------------------------------------------------- //
		
		// ----------------------- Question Slide ---------------- //
		Slide qSlide = new Slide("");
		Question q = new Question();
		q.SetText("What fraction of fish have been affected by oil based on the 10 fish you have investigated?");
		q.SetAnswers("1/10", "3/10", "5/10", "10/10");
		q.SetRightAnswer("5/10");
		q.SetHint("Take the number of fish that have been affected by oil and divide it by the total number of fish.");
		q.SetDescriptionOfRightAnswer("Great!  Dividing the number of affected fish by the total number of fish, we can derive that 5/10ths of the fish have been affected by pollution!");
		
		qSlide.AttachQuestion(q);
		slides.Add (qSlide);
		// -------------------------------------------------------- //
		
		
		// ----------------------- Question Slide ---------------- //
		qSlide = new Slide("");
		q = new Question();
		q.SetText("What is the probability that the next fish you check would be affected by oil if 5 of the last 10 fish you checked were affected by oil?");
		q.SetAnswers("10%", "30%", "50%", "100%");
		q.SetRightAnswer("50%");
		q.SetHint("The probability that the next fish is affected by oil is the same as the observed fraction of fish that have been affected by oil.");
		q.SetDescriptionOfRightAnswer("Great!  If 5/10ths of the fish are affected by pollution, that means that 0.5 times the number of fish is how many fish are affected by pollution.");
		
		qSlide.AttachQuestion(q);
		slides.Add (qSlide);
		// -------------------------------------------------------- //
		
		// ----------------------- Question Slide ---------------- //
		qSlide = new Slide("");
		q = new Question();
		q.SetText("If we discovered that in this area of the bay, a fish had a probability of 20% that it would be affected by pollution, how many fish would we expect to be sick out of 10?");
		q.SetAnswers("1", "2", "5", "8");
		q.SetRightAnswer("2");
		q.SetHint ("Multiply 10 by 20% (or 0.2) to determine how many fish we would expect.");
		//q.SetHint("The probability that the next fish is affected by oil is the same as the observed fraction of fish that have been affected by oil.");
		q.SetDescriptionOfRightAnswer("Great! We can expect an amount of fish to be affected by pollution equal to the probability multiplied by the amount of fish we will investigate.");
		
		qSlide.AttachQuestion(q);
		slides.Add (qSlide);
		// -------------------------------------------------------- //

		this.slides = slides;
		
	}
	
	void OnGUI () 
	{
		slides.OnGUI(gameObject);
	}
	
	void Update () 
	{
		slides.Update(gameObject);
	}
}

