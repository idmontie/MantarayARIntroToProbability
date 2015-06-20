using System;
using UnityEngine;


public class LessonExploringVariability : MonoBehaviour 
{
	Slides slides = null;
	
	
	void Start ()
	{
		Assets assets = Assets.GetInstance();
		Slides slides = new Slides("LessonExploringVariability");

		slides.Add(new Slide(
			"Comparing Different Samples\n\n" +
			"Let's discover first hand what variability is and how we can use it in real world situations."
		));

		slides.Add (new Slide (
			"Here is a scenario: An oil spill has caused fish to become sick. You have been tasked to figure out the effects of that oil spill on the first population of fish.\n\n" +
			"Let's compare the results we took from the Bay Area with a new sample from Lake Eerie."
		));
		
		// --------------------- Experience Slide ---------------- // 
		Slide arSlide = new Slide(
			"Point your device at the Shallow Area."
		);
		
		FishExperience e = new FishExperience(typeof(FishBehavior), arSlide);
		e.SetTarget(GameObject.Find (assets.ShallowArea));
		e.AddGameObject(assets.RandomHealthyFish());
		e.AddGameObject(assets.RandomHealthyFish());
		e.AddGameObject(assets.RandomHealthyFish());
		e.AddGameObject(assets.RandomHealthyFish());
		e.AddGameObject(assets.RandomHealthyFish());
		e.AddGameObject(assets.RandomHealthyFish());
		e.AddGameObject(assets.RandomHealthyFish());
		e.AddGameObject(assets.RandomHealthyFish());
		e.AddGameObject(assets.RandomSickFish());
		e.AddGameObject(assets.RandomSickFish());
		e.AddGameObject(assets.RandomSickFish());
		e.AddGameObject(assets.RandomSickFish());
		e.SetTotalNumberOfFish (12);
		
		arSlide.AttachExperience(e);
		
		slides.Add(arSlide);
		// -------------------------------------------------------- //
		
		// ----------------------- Question Slide ---------------- //
		Slide qSlide = new Slide("");
		Question q = new Question();
		q.SetText("What fraction of fish have been affected by oil based on the 12 fish you have investigated?");
		q.SetAnswers("1/12", "3/12", "4/12", "7/12");
		q.SetRightAnswer("4/12");
		q.SetHint("Take the number of fish that have been affected by oil and divide it by the total number of fish.");
		q.SetDescriptionOfRightAnswer("Great!  Dividing the number of affected fish by the total number of fish, we can derive that 4/12ths of the fish have been affected by pollution!");
		
		qSlide.AttachQuestion(q);
		slides.Add (qSlide);
		// -------------------------------------------------------- //
		
		
		// ----------------------- Question Slide ---------------- //
		qSlide = new Slide("");
		q = new Question();
		q.SetText("What is 4/12ths as a percentage?");
		q.SetAnswers("10%", "33.3%", "66.7%", "100%");
		q.SetRightAnswer("33.3%");
		q.SetHint("The probability that the next fish is affected by oil is the same as the observed fraction of fish that have been affected by oil.");
		q.SetDescriptionOfRightAnswer("That's correct!  4/12 = 1/3, which is 33.3%.");
		
		qSlide.AttachQuestion(q);
		slides.Add (qSlide);
		// -------------------------------------------------------- //
		
		// ----------------------- Question Slide ---------------- //
		qSlide = new Slide("");
		q = new Question();
		q.SetText("Last time, we noticed that 3/10 fish were affected.  Is that a higher or lower percentage of fish than this time (which was 4/12)?");
		q.SetAnswers("Higher", "Lower", "The Same", "");
		q.SetHint ("Calculate what 3/10ths is and calculate what 4/12ths is as a percentage.");
		q.SetRightAnswer("Lower");
		//q.SetHint("The probability that the next fish is affected by oil is the same as the observed fraction of fish that have been affected by oil.");
		q.SetDescriptionOfRightAnswer("That's right!  By counting more fish, we have discovered that the percentage of fish is actually lower than we originally estimated.");
		
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
