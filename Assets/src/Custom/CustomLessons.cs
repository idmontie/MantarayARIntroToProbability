using System;
using System.Collections;
using System.Collections.Generic;

/**
 * Custom Lesson Class.  Put the custom lessons here.  Just add it to the list!  The list is ORDERED!
 */
public class CustomLessons
{
	private List<Lesson> customLessons = new List<Lesson>();
	private static CustomLessons instance;
	
	/**
	 * Private Constructor, Singleton class.
	 * The lessons are only added once.
	 */
	private CustomLessons ()
	{
		this.customLessons.Add(new Lesson(
			"Lesson1", "Introduction"
			));
		this.customLessons.Add(new Lesson(
			"Lesson2", "Objective"
			));
		this.customLessons.Add(new Lesson(
			"Lesson3", "What is Probability?"
			));
		this.customLessons.Add(new Lesson(
			"Lesson4", "Exercise 1: Discovering Probability"
			));
		this.customLessons.Add(new Lesson(
			"Lesson5", "Fractions, Decimals, and Percentages"
			));
		this.customLessons.Add(new Lesson(
			"Lesson6", "Exercise 2: Reporting Your Data"
			));
		this.customLessons.Add (new Lesson (
			"Lesson7", "Exercise 3: The Investigation Continues!"
				));
		this.customLessons.Add(new Lesson(
			"Lesson8", "Review"
			));
		this.customLessons.Add(new Lesson(
			"Lesson9", "Probability Quiz"
			));
	}
	
	/**
	 * Get the Singleton instance of CustomLessons
	 */
	public static CustomLessons GetInstance()
	{
		if (CustomLessons.instance == null)
		{
			CustomLessons.instance = new CustomLessons();
		}
		
		return CustomLessons.instance;
	}
	
	/**
	 * Get the list of custom lessons
	 */
	public List<Lesson> GetLessons()
	{
		return this.customLessons;
	}
}


