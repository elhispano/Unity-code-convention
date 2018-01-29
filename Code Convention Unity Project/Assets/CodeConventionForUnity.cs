using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#pragma warning disable

// Summary:
// This file is organized in different classes, each class is a collection of guidelines with examples.
// Some guidelines are more concrete and other are general ideas that improve code quality.

// The file has a top-down organization from more general to more concrete things

// General conventions
// Layout and Style
// Commenting conventions
// Classes conventions
// Events conventions
// Fields conventions
// Methods/Properties conventions
// Statements conventions


// How to use it:
// The idea is to include this file and the example file in your Unity project
// so you can open it quickly in order to check anything.
// Discuss with your team this guide and modify it so that everyone feels happy with the result before start to code

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
        // ###################################################################
        // General Conventions
        // ###################################################################

        public class GeneralConventions
        {
            public void NamingConvention()
            {
                // ClassName: Class names are in mixed uppercase and lowercase with an initial capital letter. Never use plural in class names.  

                // TypeName: Type definitions, including enumerated types, use mixed uppercase and lowercase with an initial capital letter.

                // EnumeratedTypes: In addition to the rule above, enumerated types are always stated in the plural form.

                // localVariable: Local variables are in mixed uppercase and lowercase with an initial lowercase letter.The name should be independent
                // of the underlying data type and should refer to whatever the variable represents. Use plural for collections.

                // classVariable: Member variables that are available to multiple routines within a class (1). Use plural for collections.

                // _routineParameter: Routine parameters are formatted the same as local variables but they are preceded with an under slash

                // RoutineName(): Routines are in mixed uppercase and lowercase. Use plural if the routine returns a collection.

                // CONSTANT_VAR: Named constants are in ALL_CAPS.

                // STATIC_VAR: Named statics are in ALL_CAPS.

                // PropertyName: Because properties are indeed methods, we use the same convention as methods.

                // OnEventTriggered: Events names are in mixed uppercase and lowecase with an initial capital letter. All events should have a verb or verb phrase.

                // **** UNITY SPECIFICS ****

                // varNamePrefab: When a variable is a reference to a prefab, we concat the prefab keyword at the end of the variable name. We do this is to avoid
                // modifying a prefab by error.

                // varNameTemplate: When a variable is a reference to some component in the hierachy with the intention of being copied using Instantiate(varNameTemplate),
                // we add Template keyword at the end, with this we can see quickly if we are doing an invalid operation against a template (like destroying it!)

                // cachedComponentName: Use this to cached Unity components like cachedTransform, cachedAnimator, etc.  

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

                Within each of the static/non-static groups of fields, order by readonly, then non-readonly:
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


        // ###################################################################
        // Layout & Style conventions
        // ###################################################################

        // TODO: Seguir revisando por aqui.

        private class LayoutConventions
        {
            private const int END_VALUE = 99;

            private delegate void ExampleHandlerEvent();
            private event ExampleHandlerEvent OnExampleEvent1;
            private event ExampleHandlerEvent OnExampleEventWithLongerName;
            private event ExampleHandlerEvent OnExampleEvent3;

            private CodeConventionContentForExamples example = new CodeConventionContentForExamples();
            private CodeConventionContentForExamples.MethodExamples methodsExamples = new CodeConventionContentForExamples.MethodExamples();

            public void Parentheses()
            {
                // DO: Use parentheses to clarify expresions that involve more than two terms

                // GOOD:
                int result1 = 5 * (6 + 4);

                // BAD:
                int result2 = 5 * 6 + 4;
            }

            public void CodeBlocks()
            {
                // DO: Add a blank line for the begin brace

                // GOOD:
                if (example != null)
                {
                    Debug.Log(example);
                }

                // BAD:
                if (example != null)
                {
                    Debug.Log(example);
                }

                // BAD:
                // This inline method make difficulty to debug because you can't add a breakpoint inside the if
                if (example != null) { Debug.Log(example); }

                // DO: Use begin-end pairs ALWAYS to designate block boundaries. This will avoid bugs related with incorrect modifications

                // GOOD:
                if (example != null)
                {
                    Debug.Log(example);
                }

                // BAD:
                if (example != null)
                    Debug.Log(example);

                // DO: Use a new line in statements with complex expressions

                // GOOD:
                char inputChar = ' ';
                if ((('0' <= inputChar) && (inputChar <= '9')) ||
                    (('a' <= inputChar && inputChar <= 'z')) ||
                    (('A' <= inputChar && inputChar <= 'Z')))
                {

                }
            }

            private void IndividualStatements()
            {
                // DO: Break large statements in several lines making obvious the incompleteness of the statement.
                // If you have operators, put them at the beggining of the new line so all of them stay aligned

                // GOOD: 
                int arrayIndex1 = 0;
                int arrayIndex2 = 0;
                int[] exampleArray1 = new int[10];
                int[] exampleArray2 = new int[10];

                if (exampleArray1[arrayIndex1] == 0
                    || exampleArray2[arrayIndex2] == 0
                    || exampleArray1[arrayIndex1] == END_VALUE
                    || exampleArray2[arrayIndex2] == END_VALUE)
                {

                }

                // BAD: 
                if (exampleArray1[arrayIndex1] == 0 || exampleArray2[arrayIndex2] == 0 || exampleArray1[arrayIndex1] == END_VALUE || exampleArray2[arrayIndex2] == END_VALUE)
                {

                }

                // DO: Break methods with lot of parameters in several lines
                Vector3 rayOrigin = Vector3.zero;
                Vector3 direction = Vector3.up;
                RaycastHit raycastHit = new RaycastHit();
                float maxDistance = 99f;
                int layerMask = LayerMask.GetMask("Default");

                // GOOD: 
                bool hit = Physics.Raycast(rayOrigin,
                    direction,
                    out raycastHit,
                    maxDistance,
                    layerMask);

                // BAD: 
                bool hit1 = Physics.Raycast(rayOrigin, direction, out raycastHit, maxDistance, layerMask);

                // DO: Align right sides of assigment statements (1*)

                // GOOD: 
                int variableName1 = 0;
                int variableNameWithMoreLength = 0;

                OnExampleEvent1 += LayoutConventions_OnExampleEvent1;
                OnExampleEventWithLongerName += LayoutConventions_OnExampleEvent2;
                OnExampleEvent3 += LayoutConventions_OnExampleEvent3;

                // (1*): Despite knowing it is not a recommended guidline because it increases the cost to maintain the code when you rename variables
                // i beleieve that the advantages of improved readibility and the slightly chance of catching some errors make this rule worth it.

                // DO: Use only one data declaration per line

                // GOOD:
                int thisIsAnInt = 0;
                int thisIsAnotherInt = 0;

                // BAD:
                string firstName = null, lastName = null;

                // DO: Order declarations by type

                // GOOD:
                Vector3 velocity = Vector3.zero;
                Vector3 acceleration = Vector3.zero;
                float maxSpeedInKmH = 120;

                // BAD:
                Vector3 velocity1 = Vector3.zero;
                float maxSpeedInKmH1 = 120;
                Vector3 acceleration1 = Vector3.zero;
            }

            private void LayoutConventions_OnExampleEvent1()
            {
                throw new System.NotImplementedException();
            }

            private void LayoutConventions_OnExampleEvent2()
            {
                throw new System.NotImplementedException();
            }

            private void LayoutConventions_OnExampleEvent3()
            {
                throw new System.NotImplementedException();
            }

        }

        // ###################################################################
        // Class Conventions
        // ###################################################################

        public class ClassConventions
        {
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

        // ###################################################################
        // Variable Conventions
        // ###################################################################

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

        // ###################################################################
        // Event Conventions
        // ###################################################################

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

        // ###################################################################
        // Properties Conventions
        // ###################################################################

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

        // ###################################################################
        // Methods Conventions
        // ###################################################################

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
                // DO: Put initialization code directly before the loop

                // DO: Prefer for loops instead of foreach loops if possible. For loops ar faster in Unity that foreach loops

                // DO NOT: Use a for loop when a while loop is more appropriate

                // DO: Use { and } to enclose statements in a loop always to prevent errors when code is modified.

                // GOOD:
                for(int i = 0; i < 100; i++)
                {
                    Debug.Log(i);
                }

                // BAD:
                for (int i = 0; i < 100; i++)
                    Debug.Log(i);

                // DO: Keep loop-housekeeping chores at either the beginning or the end of the loop

                // DO: Make each loop perform only one function. Loops should be like routines. 
                // An exception of this rule it is in places where performance is critical

                // DO: Make sure the loop ends. This is specially important in some while loops that are potentially dangerous as infinite loops

                // GOOD:
                float securityTimer = 0f;
                while (example.Status != CodeConventionContentForExamples.StatusEnum.Ok && securityTimer < 10f)
                {
                    // Do something 

                    securityTimer += Time.deltaTime;
                }

                if(securityTimer >= 10f)
                {
                    Debug.Log("TimeOut");
                }

                // BAD:
                while (example.Status != CodeConventionContentForExamples.StatusEnum.Ok)
                {

                }

                // DO: If you need to use continue in a for loop, do it at the top of the loop

                // GOOD:
                for(int i = 0; i < 100; i++)
                {
                    if (example.Status != CodeConventionContentForExamples.StatusEnum.Ok)
                        continue;
                }

                // DO: Use meaningful variable names to make nested loops readable

                // GOOD:
                for(int month = 0; month < 12; month++)
                {
                    for(int day = 0; day < 31; day++)
                    {

                    }
                }

                // BAD:
                for (int i = 0; i < 12; i++)
                {
                    for (int j = 0; j < 31; j++)
                    {

                    }
                }

                // DO: Limit nesting of loop to three levels. Break the loops into routines if you need it to avoid this

                // DO: Make long loops specially clear
            }
        }

        private class UnityConventions
        {
            CodeConventionContentForExamples example = new CodeConventionContentForExamples();

            private MonoBehaviour dummyComponent = null;

            // ###################################################################
            // Loops
            // ###################################################################

            // DO: If you have to wait for one frame, and you are not working with graphic stuff, use "yield return null" instead of "yield return new WaitForEndOfFrame()"
            // doing this you will avoid memory allocation in each execution of the loop

            // Note: It's important to know that  yield return null is not evaluated in the same moment than WaitForEndOfFrame(); 
            // https://answers.unity.com/questions/755196/yield-return-null-vs-yield-return-waitforendoffram.html

            // GOOD:
            IEnumerator WaitOneFrameGood()
            {
                while(true)
                {
                    yield return null;
                }
            }

            // BAD:
            IEnumerator WaitOneFrameBad()
            {
                while (true)
                {
                    yield return new WaitForEndOfFrame();
                }
            }

            // DO: Be aware of living coroutines when you exit from a scene or a game section

            void Open()
            {
                example.DummyGameObject.GetComponent<MonoBehaviour>().StartCoroutine(LivingCoroutine());
            }

            void Close()
            {
                // NOTE that the LivingCoroutine is using this.example object
                this.example = null;
            }

            IEnumerator LivingCoroutine()
            {
                // IF Close is called this coroutine will keep being called because it was launched in another GameObject (can happen with a singleton for example)
                while(true)
                {
                    // CRASH!! This will crash after Close() was called
                    Debug.Log(this.example.DummyGameObject.name);
                }
            }

            // DO: Launch coroutines using method references instead of method names so we can always search for refences

            void LaunchCoroutineExample()
            {
                // GOOD:
                dummyComponent.StartCoroutine(CoroutineExample());

                // BAD:
                dummyComponent.StartCoroutine("CoroutineExample");
            }


            IEnumerator CoroutineExample()
            {
                yield return null;
            }

            // DO: Stop coroutines using the coroutine reference not the coroutine name

            void StopCoroutineExample()
            {
                var dummyCoroutine = dummyComponent.StartCoroutine(CoroutineExample());

                // GOOD:
                dummyComponent.StopCoroutine(dummyCoroutine);

                // BAD:
                dummyComponent.StopCoroutine("CoroutineExample");
            }

            // DO: If your project rely on a heavy use of coroutines, consider doing a coroutine manager 
            // Here is one example: https://assetstore.unity.com/packages/tools/coroutine-manager-pro-53120

            // DO: If you have to start a coroutine frome more than one place or from other class, create a private method to start the coroutine
            // doing this we avoid calling by accident the coroutine method WITHOUT StartCoroutine which causes a silent error in Unity

            // GOOD:
            public void RequestDataFromServer()
            {
                dummyComponent.StartCoroutine(RequestDataFromServerCoroutine());
            }

            IEnumerator RequestDataFromServerCoroutine()
            {
                yield return null;
            }
        }

        // ###################################################################
        // Comments conventions
        // ###################################################################

        private class CommentsConventions
        {
            private CodeConventionContentForExamples example = new CodeConventionContentForExamples();

            // DO: Write code that is enough clear to be a "self-documenting" code. If you have to write a comment just because the code is so complicated, 
            // it is better to improve the code that write the comment

            // DO NOT: Write comments that repeats what the code does

            // DO: Do write comments that summary the code to help other programmers at reading the code

            // DO: Write comments to describe the code's intent. Use always vocabulary in the domain of the problem instead of triying to describe the solution

            // GOOD:
            // get current employee information

            // BAD:
            // update employeeRecord object

            // DO NOT: Leave big regions of code commented when you commit to developer. Use the version repository to see old code.

            // DO NOT: Leave code until the end. You need to integrate commenting into your development style. This will help others in code reviews and also will help you
            // to think more about the problem you are triying yo solve

            // DO NOT: Use endline comments (except for data declarations or end of blocks)

            // GOOD

            /// <summary>
            /// Explain what this method does
            /// </summary>
            private void ExampleMetho1d()
            {

            }

            // BAD
            private void ExampleMethod2() // Explain what this method does
            {

            }

            // DO: Use endline comment to annotate data declarations

            // GOOD
            private int playerIndex = 0; // Index of the player in the list of players of this lobby

            // DO: Use endline comments to mark end of blocks

            // GOOD

            private void ExampleMethod3()
            {
                if (example.Status == CodeConventionContentForExamples.StatusEnum.Ok)
                {
                    // JUST IMAGINE A VERY LARGE IF BLOCK
                    // ...
                    // ...
                    // ...
                    // ...
                    // ...  

                } // End of STatus == Ok condition
            }

            // DO: Use comment to justify violations of good programming style

            // DO: Use comments to explain optimizations or to explain why you have used a more complicated approach to solve a problem instead of a more straighforward one

            // DO: Comment units of numeric data (no matter if the unity of the data form part of the variable name)

            // DO: Comment the gange of allowable numeric values

            // GOOD:

            /// <summary>
            /// Player normalized progress in this level between 0 and 1
            /// </summary>
            public float normalizedProgress = 0f;

            // CONSIDER: Commenting enums values if they are not obvious


            // DO: When commenting class members as methods, fields and properties, use the default format in c# (automatically generated if you write ///)

            // GOOD:

            /// <summary>
            /// Summary of the method here
            /// </summary>
            /// <param name="_param1"> Describe the parameter, describe expected values, units, etc</param>
            /// <returns> Describe the return value </returns>
            public int Method1(int _param1)
            {
                return 0;
            }

            // Because to much comments decrease code readability, we should rely in clean code, small & simple classes instead of commenting everything.
            // in order to know what to comment, follow the next guide:

            // Fields: because class fields are protected or private, you should only comment fields that aren't clear enough with the field name
            // Public Methods/Properties: THey should be commented. Be aware of methods with more than two lines of comment, they can be a synthom of a design problem
            // Private methods/properties: They only should be commented if their purpose isn't clear

            // DO: Comment classes describing their design approach, limitations, usage assumptions and so on

        }

    }
}