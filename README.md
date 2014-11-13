Mantaray AR
===========

# Introduction to Probability and Statistics


This application is a Unity Project that utilizes Vuforia for Augmented Reality.

# Unity

The Unity aspect of the project is written in C#.  Originally, the project was a bundle of Javascript and C# files,
but we ported over to C# as we found it to be the more robust language.

THe source of the project is made to be flexible and reuseable.  The base files should be able to be used for many different lessons.

The C# source is in the /Assets/src folder and is split up into:

* Custom - Files that are dependent on the lesson being taught.  These are static classes that are the same as those that would be loaded in
when using the dynamic version of the application (Mantaray AR: Unlimited).
* GameObjectScript - In Unity, scripts need to be attached to Game Objects.  These are the entry points for our app.
* GUI - Base classes for better GUI functions.  Trust me, you do not want to use the default stuff, it is a nightmare to deal with when you
actually start making complicated GUIs.
- Models - Application models ( not 3D models ).
- Slides - Basic slide logic.
- Util - Game utility classes.  These are really Helpers in disguise.