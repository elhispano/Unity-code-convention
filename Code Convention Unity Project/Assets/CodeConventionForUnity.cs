﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#pragma warning disable

// This file is organized in different classes, each class is a collection of guidelines.
// The file has a top-down organization from more general to more concrete things
// Summary - quick overview of conventions
// Class conventions
// Events conventions
// Variable conventions
// Routine conventions
// Statements conventions
// Commenting conventions

// In order to work with Unity, some special considerations are present in this guide.

// As stated in "Code Complete Second Editions" the purpose of this convention is the following:
// https://www.amazon.com/Code-Complete-Practical-Handbook-Construction/dp/0735619670

// ■ They let you take more for granted.By making one global decision rather than
// many local ones, you can concentrate on the more important characteristics of
// the code.

// ■ They help you transfer knowledge across projects.Similarities in names give you
// an easier and more confident understanding of what unfamiliar variables are
// supposed to do.

// ■ They help you learn code more quickly on a new project.Rather than learning
// that Anita’s code looks like this, Julia’s like that, and Kristin’s like something
// else, you can work with a more consistent set of code.

// ■ They reduce name proliferation. Without naming conventions, you can easily
// call the same thing by two different names.For example, you might call total
// points both pointTotal and totalPoints.This might not be confusing to you when
// you write the code, but it can be enormously confusing to a new programmer
// who reads it later.

// Feel free to share this file with your team-mates 

namespace CodeConventions
{ 
    public class CodeConventionForUnity
    {
        public class ConventionsSummary
        {
            public void NamingConvention()
            {
                // ClassName: Class names are in mixed uppercase and lowercase with an initial capital letter.   

                // TypeName: Type definitions, including enumerated types and typedefs, use mixed uppercase and lowercase with an initial capital letter.

                // EnumeratedTypes: In addition to the rule above, enumerated types are always stated in the plural form.

                // localVariable: Local variables are in mixed uppercase and lowercase with an initial lowercase letter.The name should be independent
                // of the underlying data type and should refer to whatever the variable represents.

                // classVariable: Member variables that are available to multiple routines within a class (1)

                // _routineParameter: Routine parameters are formatted the same as local variables but they are preceded with an under slash

                // RoutineName(): Routines are in mixed uppercase and lowercase.

                // CONSTANT_VAR: Named constants are in ALL_CAPS.

                // STATIC_VAR: Named statics are in ALL_CAPS.

                // PropertyName: Because properties are indeed methods, we use the same convention

                // OnEventTriggered: Events names are in mixed uppercase and lowecase with an initial capital letter. All events should have a verb or verb phrase.

                // **** UNITY SPECIFICS ****

                // varNamePrefab: When a variable is a reference to a prefab, we concat the prefab keyword at the end of the variable name. We do this is to avoid
                // modifying a prefab by error.

                // varNameTemplate: When a variable is a reference to some component in the hierachy with the intention of being copied using Instantiate(varNameTemplate),
                // we add Template keyword at the end, with this we can see quickly if we are doing an invalid operation against a template (like destroying it!)

                // cachedComponentName: Use this to cached unity components like cachedTransform, cachedAnimator, etc.  

                // *************************

                // NOTES:
                // (1) We don't need to differentiate between local vars and class vars because we usually has different names. You can always can use this.varName 
                // to differentiate between two vars with the same name is needed
            }

            public void ClassOrder()
            {
                /* Within a class, struct, or interface, elements must be positioned in the following order:
            
                1 - Constant Fields
                2 - Fields
                3 - Constructors
                4 - Finalizers (Destructors)
                5 - Delegates
                6 - Events
                7 - Enums
                8 - Properties
                9 - Indexers
                10 - Methods
                    10.1 - Unity Methods
                    10.2 - Handlers
                    10.3 - Class methods
                11 - Structs
                12 - Classes 

                Within each of these groups order by access:

                public
                internal
                protected internal
                protected
                private

                Within  each of the access groups, order by static, then non-static:

                static
                non-static

                Within each of the static/non-static groups of fields, order by readonly, then non-readonly : (SA1214 and SA1215)
                readonly
                non-readonly

                Unrolled example:

                public static methods
                public methods
                internal static methods
                internal methods
                protected internal static methods
                protected internal methods
                protected static methods
                protected methods
                private static methods
                private methods

                */
            }

            public void ValidOpposites()
            {
                // To help consistency (and readability) you should use this kind of opposites precisely

                //add - remove 
                //increment - decrement 
                //open - close
                //begin - end
                //insert - delete
                //show - hide

                //create - destroy
                //lock- unlock
                //source - target
                //first - last
                //min - max
                //start - stop
                //current - next - previous
                //up - down
                //get - set
                //old - new
            }
        }

        public class ClassConventions
        {
            #region CLASS ORDER
 
            // Here there is an example of a class in the propper order

            // 1 - Constatns
            public const string CONSTANT_FIELD = "All constants go first";

            private const string CONSTANT_FIELD_PRIVATE = "Private goes always after public :P";

            // 2 - Fields

            public static readonly int[] STATIC_WITH_READONLY_TABLE = new int[] {1,1,2,3,5,8};

            public static string STATIC_STRING = "";

            private static string HIDDEN_STATIC_STRING = "";

            // NOTE: As you already know ;), is not a good practice to use public fields, you must use accesor methods (get/set)
            public int examplePublicField = 0;

            protected int protectedField = 0;

            private int[] privateArray = new int[] { 0, 1, 2, 3, 4 };

            // **** UNITY SPECIFICS ****
            // If you need a field to the Unity inspector avoiding the violation of the encapsulation principle we can use:
            [SerializeField]
            private int thisIntMustBeSerializable = 0;
            // *************************


            // 3 - Constructors 
            public ClassConventions()
            {
            
            }

            // 4 - Destructors 
            ~ClassConventions()
            {
            
            }

            // 5 - Delegates
            public delegate void ButtonClickHandler(GameObject _target);
            public delegate void WindowClosedHandler(MonoBehaviour _window);

            // 6 - Events
       
            public event ButtonClickHandler OnClicked;

            // 7 - Enums
            public enum ExampleEnum
            {
                None    = 0,
                Enum1   = 1,
                Enum2   = 2,
            }

            // 8 - Properties
            public int ExampleProperty { get; private set; }

            // 9 - Indexers
            public int this[int _index]
            {
                get { return privateArray[_index]; }
                set { privateArray[_index] = value; }
            }

            // 10.1 - Unity Methods

            void Awake()
            {

            }

            // Note: Provide services in pairs with their opposites
            void OnEnable()
            {
                OnClicked += ClassConventions_OnClicked;
            }

            void OnDisable()
            {
                OnClicked -= ClassConventions_OnClicked;
            }

            // 10.2 - Handlers

            private void ClassConventions_OnClicked(GameObject _target)
            {
                throw new System.NotImplementedException();
            }

            // 10.3 - Class methods

            public void Open()
            {

            }

            public void Close()
            {

            }

            private void PrivateMethod()
            {

            }

            // 11 - Structs

            public struct NestedStruct
            {
                public int exampleInt;
            }

            // 12 - Classes

            private class NestedClass
            {
                public int exampleInt = 0;
            }
            #endregion

            #region TEST
            private void ClassNames()
            {
                // 1 - Use Pascal case

                // 2 - Use noun or noun phrase to name a class

                // 3 - Use abbreviations sparingly.

                // Where appropriate, use a compound word to name a derived class. The second part of the derived class's name should be the name of the base class. 
                // For example, ApplicationException is an appropriate name for a class derived from a class named Exception, because ApplicationException is a kind of Exception. 
                // Use reasonable judgment in applying this rule. For example, Button is an appropriate name for a class derived from Control. 
                // Although a button is a kind of control, making Control a part of the class name would lengthen the name unnecessarily.
            }
            #endregion

            private void ClassConsiderations()
            {
                // Provide services in pairs with their opposites (Open & Close, OnEnable & OnDisable, Enter & Exit, etc)

                // Move unrelated information to another class

                // Don’t expose member data in public

                // Minimize accessibility of classes and members (hide as much information as possible)

                // Keep the number of routines in a class as small as possible

                // Avoid deep inheritance trees

                // Try to preserve the Law of Demeter which helps to keep low the coupling of the class with other classes:
                // Each unit should have only limited knowledge about other units: only units "closely" related to the current unit.
                // Following this principle implies avoiding this kind of lines: otherClass.otherComponent.whateverThing.transform.position
            }
        }

        private class VariableConventions
        {
            private void VariableDeclarations()
            {
                // 1- Initialize all variables

                // DO: int myInt = 0;
                // DO NOT: int myInt;
                // DO: string name = null;
                // DO NOT: string name;

                // 2 - Initialize each variable close to where it's firts used,
                // this will preserve the Principle of Proximity: keep related actions together

                // DO:
                // string address = null;
                // adress = GetAdress(userId);
                //
                // string phoneNumber = null;
                // phoneNumber = GetPhoneNumber(userId);

                // 3 - If possible, declare and define each variavle where it's first used:
                // CONSIDER:
                // string address = GetAdress(userId);;

                // DO NOT:
                // string address = null;
                // string phoneNumber = null;
                //
                // adress = GetAdress(userId);
                // phoneNumber = GetPhoneNumber(userId);

                // 4 - Check input paramaters before assignation
                // Before assigning an input paramaters, makre sure that the values are reasonable (1)

                // 5 - Group related statements

                // DO
                // GetNewData(bewData);
                // var totalNewData = Sum(newData);
                // GetOldData(oldData);
                // var totalOldData = Sum(oldData);

                // DO NOT:
                // GetOldData(oldData);
                // GetNewData(bewData);
                // var totalOldData = Sum(oldData);
                // var totalNewData = Sum(newData);

                // 6 - Use each variable for one purpose only to improve readibility

                // DO:
                // var score = CalculateScore();
                // ShowScore(score);
                // var health = CalculateCombatHealth();
                // ApplyHealth(health)

                // DO NOT:
                // var temp = CalculateScore();
                // ShowScore(temp);
                // temp = CalculateCombatHealth();
                // ApplyHealth(temp)

                // 7 - Avoid variables with hidden meanings to avoid "hybrid coupling"

                // DO NOT:
                // int lives = GetAvailableLives()
                // if(lives == -1)
                // {
                //   ShowError(ERROR_GETTING_LIVES);
                // }
                // else
                // {
                //   ConfigureLivesCounter(lives);
                // }
                // In this case, the variable lives has two meanings: the quantity of lives of the player AND a boolean to indicates than an error has occurred.

                // 8 - Make sure all declared variables are used.
                // You can see Warnings in the console to remove unused variables.
                
                // 9 - Use 'var' keyword in variable declarations except for numeric variables
                // - Code maintenance is improved
                // - Code readability is improved 

                // DO:
                // var player = Game.GetPlayer();

                // DO NOT:
                // Player player = Game.GetPlayer();

                // DO NOT:
                // var max = GetMax();
                // var result = current / max;
                // If we use var, we can't see of there is an error due to the type of the operators, in this example, result can be 0 if max is an int

                // Note (1): If you are concerned about performance, you can use Assertions (Unity Debug.Assert)
            }

            private void VariableNames()
            {
                // 1 - Try to avoid computer related terms and use problem domain terms.

                // DO:
                // playerSaveGame

                // DO NOT:
                // diskFile

                // 2 - Optimum name length:
                // - Avoid too short, too long, hard to type, hard to pronounce variable names
                // - Desired variable name length: Between 8 and 20 characters

                // 3 - If the variable has a qualifer like: Total, Sum, Average, Max, Min, Record, String, Pointer, etc
                // put it at the end of the name

                // DO:
                // scoreTotal
                // healthAverage
                // playerNameLabel

                // 4 - CONSIDER using more descriptive names for loops indexs to improve readibility

                // 5 - Use more detailed index names for nested loops to avoid index corss-talk errors (saying i when you mean j and vice versa)

                // DO:
                //for (teamIndex = 0; teamIndex < teamCount; teamIndex++)
                //{
                //    for (eventIndex = 0; eventIndex < eventCount[teamIndex]; eventIndex++)
                //    {
                //        score[teamIndex][eventIndex] = 0;
                //    }
                //}

                // 6 - Give boolean variables names that imply true or false as: done, error, found, success, ok, etc.

                // 7 -  Use positive boolean variable names:

                // DO:
                // found

                // DO NOT:
                // notFound


                // 8 - Avoid using names with similar meanings

                // DO NOT:
                // var fileNumber
                // var fileIndex


                // 9 - Avoid using similar names in variables with different meaning

                // DO: 
                // var screenArea
                // var screenResolution

                // DO NOT:
                // var screenRect
                // var screenRes

                // 10 - Avoid names that sound similar

                // 11 - Avoid numerals in names. If you feel you need numerals probably you need a different data type as an array
            }

            public void NumericVariablesConsiderations()
            {
                // 1 - Avoid magic numbers

                // DO:
                // var fallSpeed = initialSpeed + GRAVITY_ACCELERATION*time;
                // DO NOT:
                // var fallSpeed = initialSpeed + 9.8f*time;

                // 2 - Anticipate divide-by-zero errors

                // 3 - Make data type conversions explicit in mathematical operations

                // DO:
                // y = x + (float)i;

                // DO NOT:
                // y = x + i;

                // 4 - Avoid midex-type comparitons

                // DO:
                // if (i == (int)x)

                // DO NOT:
                // if(i == x)

                // 5 - Be careful with integer divisions
                // 10 * (7/10)  will return 0 in C#

                // 6 - Be careful with integer overflow, you should think about the largest value your expression can assume.

                // 7 - Avoid add/substract on numbers that have greatly different magnitudes with float numbers
                // 1,000,000.00 + 0.1 can have a result of 1,000,000.00

                // 8 - Avoid equality comparisons in floating-point numbers

                // DO:
                // if(maximumSpeed - speed < MAX_SPEED_DELTA)

                // DO NOT:
                // if(speed == maximumSpeed)
            }

            public void CharacterAndStringsConsiderations()
            {
                // 1 - Avoid magic strings

                // DO:
                // titleLabel.text = LocalizationSystem.GetText(WINDOW_TITLE_KEY);

                // DO NOT:
                // titleLabel.text = LocalizationSystem.GetText("Window title key");

                // 2 - Use string.Format() to compose strings

                // DO:
                // ShowMessage(string.Format("You have won {0} points",score));

                // DO NOT:
                // ShowMessage("You have won "+score+" points");

                // 3 - Use string.IsNullOrEmpty to check for empty/null strings

                // DO:
                // if(string.IsNullOrEmpty(userName))

                // DO NOT:
                // if(userName == null || userName == "")

                // 4 - Consider using the StringBuilder class if you need to work with long strings to reduce the impact on performance
                //string text = null;

                // DO:
                // System.Text.StringBuilder sb = new System.Text.StringBuilder();
                // for (int i = 0; i < 100; i++)
                // {
                //     sb.AppendLine(i.ToString());
                // }

                // DO NOT:
                // string text = null;
                // for (int i = 0; i < 100; i++)
                // {
                //     text += i.ToString();
                // }
            }

            public void BooleansConsiderations()
            {
                // 1 - Use boolean variables to increase readibility and maintenance in logic expressions 

                // DO:
                // var finished = (( elementIndex < 0 ) || ( MAX_ELEMENTS < elementIndex ));
                // var repeatedEntry = repeatedEntry = ( elementIndex == lastElementIndex );
                // if(finished || repeatedEntry)

                // DO NOT:
                // if ((elementIndex < 0) || (MAX_ELEMENTS < elementIndex) || (elementIndex == lastElementIndex))
            }

            public void EnumeratedTypesConsiderations()
            {
                // 1 - Define always the first value in an enum for an "invalid" value

                // DO:
                // enum GameModes
                // {
                //      None,
                //      DeathMatch,
                //      TeamDeathMatch,
                //      CaptureTheFlag
                // }

                // **** UNITY SPECIFICS ****

                // 2 - Avoid adding new enum values in the middle of the enum, this will change the value of serializable variables in the Unity Inspector

                // *************************

                // 3 - Try to use the same enum values in external services to avoid name conversions

                // DO: 
                // GameMode gameMode = (GameMode)GetGameModeFromServer();
                // if(gameMode == GameModes.DeathMatch)

                // DO NOT:
                // string gameModeString = GetGameModeFromServer();
                // GameMode gameMode = GameMode.None;
                // 
                // if(gameModeString == "DEATH_MATCH")
                // {
                //      gameMode = GameMode.DeathMatch;
                // }
            }

            public void ArraysConsiderations()
            {
                // 1 - Check that array indexes are within the bounds of the array

                // 2 - Use lists if you don't know the size of the array, in other case, use arrays
            }
        }

        public class EventConventions
        {
            // 1 - Because the events always refer to some action, use verbs to name events. You should use the verb tense to indicate the time the event is raised. PascalCasing

            // DO:
            // Clicked, Painting, DroppedDown

            // DO:
            // Closing (before the window is closed)
            // Closed (the window is already closed)

            // DO NOT:
            // Close
            // BeforeClose
            // AfterClose

            // 2 - Call event handlers with the "EventHandler" suffix

            // DO: 
            // public delegate void ClickedEventHandler
        }

        public class PropertiesConventions
        {
            // 1 - Because properties refers to data, we should use noun phrase or adjective names, use PascalCasing

            // DO: 
            // public Player PlayerData {get; private set;}

            // DO NOT: 
            // public Player GetPlayerData {get; private set;}

            // 2 - Use plural if the property refers to a collection 

            // DO:
            // public List<Color> HairColors {get; set;}

            // 3 - Name boolean properties with affirmative phrases or add a prefix as "Is", "Can" or "Has"

            // DO:
            // public bool HasConnection {get; private set;}
            // public bool CanJump {get; private set;}
        }

        private class MethodsConventions
        {
            // Pagina 161
            CodeConventionContentForExamples examples = new CodeConventionContentForExamples();
            CodeConventionContentForExamples.MethodExamples examples2 = new CodeConventionContentForExamples.MethodExamples();

            private void MethodsConciserations()
            {
                // DO: Routines must have a single purpose

                // DO: Try to avoid routines over 200 lines of code (comments and blank lines are excluded). There are a lot of studies with different results 
                // so there is not an official standard in the industry. Try to avoid large routines because usually, they are consequences of bad programming practices
                // but you can always write routines over 200 lines if you need it and they are simple enough to be readable, maintenable and undertestanable.
            }

            private void MethodsNamesConsiderations()
            {
                // DO: A routine name must describe everything the routine does

                // DO NOT: Use meaningless, vague or wishy-washy verbs

                // BAD
                examples2.ComputeScore();

                // GOOD
                examples2.ComputeGameOverScore();

                // DO NOT: Don't use numbers to differentiate routine names

                // DO: Make names of routines as long as neccesary 

                // DO: If the function returns a value, to name a function use a description of the value (only when it returns a single value)

                // DO: Use verbs for routine names

                // BAD
                examples2.Score();

                // GOOD
                examples2.GetScore();

                // DO: Stablish conventions for common operations

                // BAD:
                examples2.GetId();
                examples2.Id();
                var id = examples2.ID;
            }

            private void RoutineParameters()
            {
                // DO: Put parameters in input-modify-output-
                // in the output parameters, put error/status order last

                // GOOD
                GameObject mainWeapon = null;
                GameObject instantiatedPlayer = null;
                bool skinConfigurationError = false;
                examples2.ConfigurePlayerSkin(true, ref instantiatedPlayer, out mainWeapon, out skinConfigurationError);

                // DO: If similar routines use similar parameters, put the similar parameters in a consistent order

                // DO: Use all the parameters, remove unused parameters

                // DO NOT: Don't use routine parameters as working variables, use local variables instead

                // BAD
                // void MathOperationExample(int _value)
                // {
                //      _value *= CONST;

                //      return _value;
                // }

                // DO: Limit the number of routine's parameters to about seven. If you need more parameters probably you need
                // a new class/struct to represent that data

                // DO: Pass the variables or objects that the routine needs to maintain its interface abstraction

                // GOOD:
                examples2.MethodWithGoodParameters(examples.dummyInt, examples.dummyString);

                // BAD:
                examples2.MethodWithBadParameters(examples.DummyObject);

                // DO: Use named parameters in lambda expresions and auto-generated delegates
            }

            // ###################################################################
            // METHODS RETURN VALUE
            // ###################################################################

            // DO: Have a single return point in your method, this will help to maintain and debug your code

            // GOOD:
            public int ExampleMethod1()
            {
                // DO: Initialize the return value at the beggining of the function to a default value
                int returnValueExample = 0;

                bool condition1 = false;
                bool condition2 = false;

                if (condition1)
                {
                    returnValueExample = 1;
                }
                else if (condition2)
                {
                    returnValueExample = 2;
                }

                return returnValueExample;
            }

            // BAD:
            public int ExampleMethod2()
            {
                bool condition1 = false;
                bool condition2 = false;

                if (condition1)
                {
                    return 1;
                }
                else if (condition2)
                {
                    return 2;
                }

                return 0;
            }
        }

        // ###################################################################
        // STATEMENTS
        // ###################################################################

        private class StatementsConventions
        {
            // ###################################################################
            // Conditionals
            // ###################################################################

            private CodeConventionContentForExamples example = new CodeConventionContentForExamples();

            private void Conditionals()
            {
                // DO: Write the nominal path through the code first, then write unusual cases. This improves readability and performance

                // DO: Write errors case outside the conditional where you are taking the decissions

                // GOOD:
                bool error = false;

                if(error)
                {
                    Debug.LogError("Notify of error");
                    return;
                }

                bool condition1 = false;

                if (condition1)
                {
                    // Do something
                }

                // BAD:
                if (error)
                {
                    Debug.LogError("Notify of error");
                }
                else
                {
                    if (condition1)
                    {
                        // Do something
                    }
                }

                // DO: Put the normal case after the if rather than after the else

                // GOOD:
                if (example.Status == CodeConventionContentForExamples.StatusEnum.Ok)
                {
                    // Normal case
                }
                else
                {

                }

                // BAD:
                if (example.Status != CodeConventionContentForExamples.StatusEnum.Ok)
                {
                    
                }
                else
                {
                    // Normal case
                }

                // CONSIDER: Consider to weite the else clause to make clear to other programmers that you have considered that case

                // GOOD: 
                bool validID = !string.IsNullOrEmpty(example.DummyObject.ID);
                if (validID)
                {
                    // Normal case
                }
                else
                {
                    // If the id is not valid, do nothing
                }

                // BAD: 
                if (validID)
                {
                    // Normal case
                }

                // DO: Simplify complicated tests with boolean functions calls

                // GOOD:
                bool statusIsOk = example.Status == CodeConventionContentForExamples.StatusEnum.Ok;
                if(validID && statusIsOk)
                {
                    // Do somethinf
                }

                // BAD:
                if (!string.IsNullOrEmpty(example.DummyObject.ID) && example.Status == CodeConventionContentForExamples.StatusEnum.Ok)
                {
                    // Do somethinf
                }

                // DO: In several if/else if statements, start always for the most frequent cases first

                // GOOD:
                char inputChar = ' ';
                if (example.IsLetter(inputChar))
                {
                    // Do something with letter
                }
                else if(example.IsNumber(inputChar))
                {
                    // Do something with number
                }
                else if(example.IsPunctiation(inputChar))
                {
                    // Do something with punctuations
                }
                else
                {
                    Debug.LogErrorFormat("Unrecognized char: {0}", inputChar);
                }
            }

            // ###################################################################
            // Loops
            // ###################################################################

            public void Loops()
            {
                // 368
            }

            public void UnusualCOntrolStructures()
            {

            }

            public void ArrayMethods()
            {

            }

        }

        private class UnityConventions
        {
            private void Coroutines()
            {
                // https://unity3d.com/es/learn/tutorials/topics/performance-optimization/optimizing-garbage-collection-unity-games?playlist=44069

                // Super interesante en esa guía se explica que las coroutinas allocan memoria en cada iteracion de un loop mientras esperamos
                // - Poner ejemplos
                // - Comentar que podemos esperar un frame con yield return null
            }
        }

        public class Comments
        {

        }

        private class GeneralConsiderations
        {
            // Favor read-time convenience to write-time convenience

            // Principle of Proximity: keep related actions together
        }
    }
}