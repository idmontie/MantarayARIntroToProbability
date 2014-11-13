using System;
using UnityEngine;


public class Lesson3 : MonoBehaviour 
{
	Slides slides = null;
	
	void Start ()
	{
		Assets assets = Assets.GetInstance();
		Slides slides = new Slides("Lesson3");
		
		slides.Add(new Slide(
			"What is Probability?\n\nLet's discover first hand what probability is and how we can use it in real world situations."
			));
		
		slides.Add(new Slide(
			"Our Scenario:\n" +
			"\n" +
			"An oil spill has caused fish in a lake to become sick!  You have been tasked to figure out the effects that the oil spill has had on the fish population!"
			));
		
		slides.Add(new Slide(
			"Let's begin by taking tally of how many fish we can find that have been affected by pollution!"
			));
		
		// --------------------- Experience Slide ---------------- // 
		Slide arSlide = new Slide(
			"Point your device at Lake Erie."
			);
		
		FishExperience e = new FishExperience(typeof(FishBehavior), arSlide);
		e.SetTarget(GameObject.Find (assets.LakeErie));
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
		e.SetTotalNumberOfFish (10);
		
		arSlide.AttachExperience(e);
		
		slides.Add(arSlide);
		// -------------------------------------------------------- //
		
		slides.Add(new Slide(
			"It looks like 3 in 10 fish have been affected by the oil spill!"
			));
		
		slides.Add (new Slide(
			"In other words, 30 percent of the fish have been affected by the oil spill.\n" +
			"\n" + 
			"Based on that, we can assume that of the next 10 fish we randomly pick from the lake, that 3 will also be affected by pollution."
			));
		
		// ----------------------- Question Slide ---------------- //
		Slide qSlide = new Slide("");
		Question q = new Question();
		q.SetText("We have observed that 3 of 10 fish have been affected by pollution from this sample size, how many fish can we expect to be affected by the oil spill if there are a total of 100 fish in the lake?");
		q.SetAnswers("10", "30", "40", "60");
		q.SetRightAnswer("30");
		q.SetHint("We can multiple the observed values by 10 to get the total we expect from the whole lake.");
		q.SetDescriptionOfRightAnswer("Great!  By multiplying the 3 out of 10 fish that we observed by 10, we can make the guess that 30 out 100 fish will be affected by the oil spill!");
		
		qSlide.AttachQuestion(q);
		slides.Add (qSlide);
		// -------------------------------------------------------- //
		
		slides.Add(new Slide(
			"That's where probability comes into play!  Probability is the chance that a given event will occur!"
			));
		
		slides.Add(new Slide(
			"In probability terms, there is a 30 percent (or 30%) chance of a fish being affected by pollution if our sample has 3 out of 10 affected!"
			));
		
		slides.Add(new Slide(
			"Now that you've learned what probability is, let's move on to the next lesson!"
			));

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
