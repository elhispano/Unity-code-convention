using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#pragma warning disable

// Author: Adrian Mesa Pachon 
// ContactInfo: https://www.linkedin.com/in/adrianmesa/

// -- Summary:
// This file is organized in different classes, each class is a collection of guidelines with examples.
// Some guidelines are more concrete and other are general ideas that improve code quality.

// The file has a top-down organization from more general to more concrete things

// 1 - General conventions
//  1.1 - Naming Conventions
//  1.2 - Class order
//  1.3 - Valid Opposites
//  1.4 - Project Abrevations

// 2 - Layout and Style

// 3 - Classes conventions
//  3.1 - Class Order
//  3.2 - Class Names
//  3.3 - Class Considerations

// 4 - Events conventions

// 5 - Properties conventions

// 6 - Methods/Properties conventions
//  6.1 Methods Naming Conventions
//  6.2 - Methods Parameters Conventions
//  6.3 - Methods return value conventions
//  6.4 - Methods considerations


// 7 - Variables conventions
//  7.1 Variable Declarations
//  7.2 Variable Names
//  7.3 Numbers
//  7.4 Characters And Strings
//  7.5 Booleans
//  7.6 Enums
//  7.7 Arrays

// 8 - Statements Conventions
//  8.1 - Conditionals
//  8.2 - Loops

// 9 - Comments conventions

// 10 - Unity Special Conventions
//  10.1 - Coroutines
//  10.2 - Field attributes

// -- Why i need it?
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

// -- How to use it:
// The idea is to include this file and the example file in your Unity project
// so you can open it quickly in order to check anything.
// Discuss with your team this guide and modify it so that everyone feels happy with the result before starting to code

// Because this guide has been designed to work with Unity projects, i have included some specific conventions.
// Feel free to share this file with your team-mates 

// -- Expected feedback
// Any kind of feedback is welcome, i would like to improve this guide and make it a standard


namespace CodeConventions
{ 
    public class CodeConventionForUnity
    {
        // ###################################################################
        // 1 - General Conventions
        // ###################################################################

        public class GeneralConventions
        {
            // =============================
            // 1.1 - Naming Conventions
            // =============================

            public void NamingConvention()
            {
                // ClassName: PascalCase. Never use plural in class names.  

                // TypeName: Type definitions, including enumerated types in PascalCase.

                // EnumeratedTypes: In addition to the rule above, enumerated types are always stated in the plural form.

                // localVariable: Local variables are in camelCase.The name should be independent
                // of the underlying data type and should refer to whatever the variable represents. Use plural for collections.

                // classVariable: Member variables that are available to multiple methods within a class are in camelCase(1). Use plural for collections.

                // methodParameter: Use camelCase, use plural for collections.

                // MethodName(): Methods are PascalCase. Use plural if the method returns a collection.

                // CONSTANT_VAR: Named constants are in ALL_CAPS.

                // static readonly STATIC_VAR: Use ALL_CAPS. We use this readoonly static var as const so we use the same naming rules.

                // static varName: For a regular static var we use the same style as classVariable: camelCase.

                // PropertyName: Because properties are indeed methods, we use the same convention as methods. This will help to understand that calling a
                // property can have a cost. 

                // OnEventTrigger: Events names are in mixed uppercase and lowecase with an initial capital letter. All events should have a verb or verb phrase.

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

            // =============================
            // 1.2 - Class order
            // =============================

            public void ClassOrder()
            {
                /* Within a class, struct, or interface, elements must be positioned in the following order:
            
                1 - Constant Fields
                2 - Fields
                3 - Delegate declarations
                4 - Events
                5 - Enums
                6 - Constructors
                7 - Finalizers (Destructors)
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

            // =============================
            // 1.3 - Valid Opposites
            // =============================

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

            // =============================
            // 1.4 - Project Abrevations
            // =============================

            public void ProjectAbrevations()
            {
                // Put here your project abreviations

                // Idx for Index
                // SO for ScriptableObject: buildingSO, levelRewardsSO
                // SZ for classes that are serializable in Unity: buildingSZ, levelRewardsSZ
            }
        }


        // ###################################################################
        // 2 - Layout & Style conventions
        // ###################################################################
        
        private class LayoutConventions
        {
            public void Parentheses()
            {
                // DO: Use parentheses to make clear expresions that involve more than two terms

                // GOOD:
                int result1 = (5 * 6) + 4;

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
                if (example != null){
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
                if (('0' <= inputChar && inputChar <= '9')
                    || ('a' <= inputChar && inputChar <= 'z')
                    || ('A' <= inputChar && inputChar <= 'Z'))
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
                // TODO: Decide with the team the limit of parameters to use line breaks
                Vector3 rayOrigin       = Vector3.zero;
                Vector3 direction       = Vector3.up;
                RaycastHit raycastHit   = new RaycastHit();
                float maxDistance       = 99f;
                int layerMask           = LayerMask.GetMask("Default");

                // GOOD: 
                bool hit = Physics.Raycast(rayOrigin,
                    direction,
                    out raycastHit,
                    maxDistance,
                    layerMask);

                // BAD: 
                bool hit1 = Physics.Raycast(rayOrigin, direction, out raycastHit, maxDistance, layerMask);

                // DO: Align right sides of assigment statements that belong to a same code block (1*)
                // TODO: Discuss this with the team to decide if we keep doing this or not

                // GOOD: 
                int variableName1               = 0;
                int variableNameWithMoreLength  = 0;

                OnExampleEvent1                 += LayoutConventions_OnExampleEvent1;
                OnExampleEventWithLongerName    += LayoutConventions_OnExampleEvent2;
                OnExampleEvent3                 += LayoutConventions_OnExampleEvent3;
                
                // DO: Use only one data declaration per line

                // GOOD:
                int thisIsAnInt = 0;
                int thisIsAnotherInt = 0;

                // BAD:
                string firstName = null, lastName = null;

                // DO: Order declarations by type

                // GOOD:
                Vector3 velocity        = Vector3.zero;
                Vector3 acceleration    = Vector3.zero;
                float maxSpeedInKmH     = 120;

                // BAD:
                Vector3 velocity1       = Vector3.zero;
                float maxSpeedInKmH1    = 120; // <-- float is in the middle of two vector3
                Vector3 acceleration1   = Vector3.zero;

                // Additional notes
                // (1*): Despite knowing it is not a recommended guidline because it increases the cost to maintain the code when you rename variables
                // i beleieve that the advantages of improved readibility and the slightly chance of catching some errors make this rule worth it.
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

            #region For examples
            private const int END_VALUE = 99;

            private delegate void ExampleHandlerEvent();
            private event ExampleHandlerEvent OnExampleEvent1;
            private event ExampleHandlerEvent OnExampleEventWithLongerName;
            private event ExampleHandlerEvent OnExampleEvent3;

            private Example example = new Example();
            private Example.MethodExamples methodsExamples = new Example.MethodExamples();
            #endregion
        }

        // ###################################################################
        // 3 - Class Conventions
        // ###################################################################

        private class ClassConventions
        {
            // =============================
            // 3.1 - Class Order
            // =============================

            // DO: Use the same order of class members in every class

            // 1º - Constatns
            public const string CONSTANT_FIELD = "All constants go first";


            private const string CONSTANT_FIELD_PRIVATE = "Private goes always after public :P";

            // 2º - Fields

            public static readonly int[] STATIC_WITH_READONLY_TABLE = new int[] {1,1,2,3,5,8}; // Note that we are using ALL_CAPS because the static var is readonly (is used as a const)

            public static string staticString = "";

            // NOTE: As you already know ;), is not a good practice to use public fields, you must use accesor methods (get/set)
            public int examplePublicField = 0;


            protected int protectedField = 0;


            private static string HIDDEN_STATIC_STRING = "";


            private int[] privateArray = new int[] { 0, 1, 2, 3, 4 };


            // **** UNITY SPECIFICS ****
            // If you need a field to the Unity inspector and avoid the violation of the encapsulation principle we can use [SerializeField] attribute:
            [SerializeField]
            private int thisIntMustBeSerializable = 0;

            // These should always be private and marked with the [SerialiseField] attribute. If needed, these can be exposed
            // to other scripts via public properties. Avoid changing inspector fields via script, as this can lead to unexpected behavior. 
            // Inspector fields should not be used to provide debug information to developers.
            // *************************

            // 3º - Delegates
            public delegate void ButtonClickHandler(GameObject _target);
            public delegate void WindowClosedHandler(MonoBehaviour _window);

            // 4º - Events
            public event ButtonClickHandler OnClicked;

            // 5º - Enums
            public enum ExampleEnum
            {
                None = 0,
                Enum1 = 1,
                Enum2 = 2,
            }

            // 6º - Constructors 

            // **** UNITY SPECIFICS ****
            // If your class is inheriting from Monobehaviour, you should know that the default constructor (constructor without parameters)
            // is used by the Unity serializer and you can't acces Unity objects from this constructor. 
            // DO NOT: Do not use a constructor in classes that inherit from MonoBehaviour. Instead use Awake for internal initialization, and start for external initialization
            // *************************

            public ClassConventions()
            {
            
            }

            // 7º - Destructors 
            ~ClassConventions()
            {
            
            }


            // 8º - Properties
            public int ExampleProperty { get; private set; }

            // 9º - Indexers
            public int this[int _index]
            {
                get { return privateArray[_index]; }
                set { privateArray[_index] = value; }
            }

            // 10º - Methods

            // 10.1 - Unity Methods

            void Awake()
            {

            }

            // DO: Provide services in pairs with their opposites
            void OnEnable()
            {
                OnClicked += ClassConventions_OnClicked;
            }

            void OnDisable()
            {
                OnClicked -= ClassConventions_OnClicked;
            }

            // DO NOT: Leave blank Unity methods, delete them.

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

            // 11º - Structs

            public struct NestedStruct
            {
                public int exampleInt = 0;
            }

            // 12º - Classes

            private class NestedClass
            {
                public int exampleInt = 0;
            }

            // =============================
            // 3.2 - Class Names
            // =============================

            private void ClassNames()
            {
                // DO: Use Pascal case for class names

                // DO: Use noun or noun phrase to name a class

                // DO: Use abbreviations sparingly.

                // CONSIDER: Using a compound word to name a derived class. The second part of the derived class's name should be the name of the base class. 
                // For example, ApplicationException is an appropriate name for a class derived from a class named Exception, because ApplicationException is a kind of Exception. 
                // Use reasonable judgment in applying this rule. For example, Button is an appropriate name for a class derived from Control. 
                // Although a button is a kind of control, making Control a part of the class name would lengthen the name unnecessarily.

                // DO: Use the preffix I to naming Interfaces

                // DO NOT: Use Abstract or Base as prefix of Abstract Classes. You should regular name conventions to define the name of abstract classes.
                // GOOD:
                // Shape (abstract class) Square (child class), Circle (child class)
            }

            // =============================
            // 3.3 - Class Considerations
            // =============================

            private class ClassConsiderations
            {
                // DO: Provide services in pairs with their opposites (Open & Close, OnEnable & OnDisable, Enter & Exit, etc)

                // GOOD:
                public void Enter()
                {

                }

                public void Exit()
                {

                }

                public void Update()
                {

                }

                // BAD:
                public void Enter1()
                {

                }

                public void Update1()
                {

                }

                public void Exit1()
                {

                }

                // DO: Move unrelated information to another class

                // DO: Don’t expose member data in public

                // GOOD:
                [SerializeField]
                private GameObject explosionPrefab = null;
               
                // BAD:
                public GameObject deadParticlesPrefab = null;

                // DO: Minimize accessibility of classes and members (hide as much information as possible)

                // DO: Keep the number of methods in a class as small as possible. Consider creating new clasess to keep each class small

                // DO: Avoid deep inheritance trees

                // DO: Preserve the Law of Demeter which helps to keep low the coupling of the class with other classes:
                // Each unit should have only limited knowledge about other units: only units "closely" related to the current unit.
                // Following this principle implies avoiding this kind of lines: otherClass.otherComponent.whateverThing.transform.position
            }
        }

        // ###################################################################
        // 4 - Event Conventions
        // ###################################################################

        private class EventConventions
        {
            // DO: Because the events always refer to some action, use verbs to name events. 
            // Use the verb tense to indicate the time the event is raised

            // GOOD:
            // Clicked, Painting, DroppedDown
            public event Action Click;
            public event Action Clicked;
            public event Action Closed;

            // BAD:
            public event Action BeforeClose;
            public event Action AfterClose;


            // DO: Call event handlers with the "EventHandler" suffix

            // GOOD:
            public delegate void ClickEventHandler(Button _button);

            // CONSIDER: When the handler of an event have recognozible parameters, you can use Action, when this
            // paramater aren't clear, declare a delegate with the name of the parameters

            // Example:
            // GOOD:
            public event Action<Example.StatusEnum> StatusChanged; // There is no doubt with the parameter of this event

            // BAD:
            public event Action<int, int, int> ScoreChanged; // In this case, the parameters aren't clear

            // GOOD
            public delegate void ScoreChangeHandler(int newScore, int previousScore, int bestScore);
        }

        // ###################################################################
        // 5 - Properties Conventions
        // ###################################################################

        private class PropertiesConventions
        {
            // DO: Because properties refers to data, we should use noun phrase or adjective names

            // GOOD: 
            public System.Object PlayerData {get; private set;}

            // BAD: 
            public System.Object GetPlayerData {get; private set;}

            // DO: Use plural if the property refers to a collection 

            // GOOD: 
            public System.Object[] TeamMembers { get; private set; }


            // DO: Name boolean properties with affirmative phrases or add a prefix as "Is", "Can" or "Has"

            // GOOD:
            public bool HasConnection {get; private set;}
            public bool CanJump {get; private set;}
        }

        // ###################################################################
        // 6 - Methods Conventions
        // ###################################################################

        private class MethodsConventions
        {
            Example examples = new Example();
            Example.MethodExamples examples2 = new Example.MethodExamples();

            // ================================
            // 6.1 Methods Naming Conventions
            // ================================

            // DO: A method name must describe everything the method does

            // GOOD
            void ComputeGameOverScoreAndUploadToServer()
            {

            }

            // BAD
            void GameOverScore()
            {

            }

            // DO NOT: Use meaningless, vague or wishy-washy verbs

            // GOOD:
            void UploadGameResults()
            {

            }

            // BAD:
            void Upload()
            {

            }

            // DO NOT: Don't use numbers to differentiate method names unless those numbers have a logical meaning in that context.

            // GOOD:
            void PlaySound(AudioClip _clip)
            {

            }


            void PlaySound(AudioClip _clip,float _volume)
            {

            }

            // BAD:
            void PlaySound1(AudioClip _clip)
            {

            }

            void PlaySound2(AudioClip _clip, float _volume)
            {


            }

            // DO: Make names of methods as long as neccesary. If the method name get too long, consider this as a signal to split the method in two methods.

            // DO: Use verbs for method names

            // DO: If the function returns a value, to name a function use a description of the value (only when it returns a single value)

            // DO: Stablish conventions for common operations

            // BAD:

            // You are using two different method names to get an Id, choose one form and stick to it.

            int GetId()
            {
                return 0;
            }

            int Id()
            {
                return 0;
            }

            // ================================
            // 6.2 - method Parameters Conventions
            // ================================

            private void MethodParametersOrder()
            {
                // DO: Put parameters in input-modify-output-
                // in the output parameters, put error/status order last

                // GOOD
                GameObject mainWeapon = null;
                GameObject instantiatedPlayer = null;
                bool skinConfigurationError = false;
                examples2.ConfigurePlayerSkin(true, ref instantiatedPlayer, out mainWeapon, out skinConfigurationError);
            }

            // DO: method parameters start with a underscore '_'

            // GOOD:
            void ExampleMethod(int _parameter)
            {

            }

            // DO: If similar methods use similar parameters, put the similar parameters in a consistent order

            // DO: Use all the parameters, remove unused parameters. If you need to keep compatibility for legacy code, make use of [Obsolete] attribute

            // DO NOT: Don't use method parameters as working variables, use local variables instead

            // BAD:
            int MathOperationExampleBad(int _value)
            {
                _value *= 5;

                return _value;
            }

            // GOOD:
            int MathOperationExampleGood(int _value)
            {
                int result = _value * 5;

                return _value;
            }

            // DO: Limit the number of method's parameters to about seven. If you need more parameters probably you need
            // a new class/struct to represent that data

            // EXAMPLE:
            public void MethodParametersLimit(int value1, int value2, int value3, int value4, int value5, int value6, int value7)
            {

            }

            // DO: Pass the variables or objects that the method needs to maintain its interface abstraction. Note that this can be subtle 
            // and in some cases, passing the entire object as parameter is OK if the two clases are coupled.

            void ParatemersAbstractionExample()
            {
                // GOOD:
                examples2.MethodWithGoodParameters(examples.dummyInt, examples.dummyString);

                // BAD:
                examples2.MethodWithBadParameters(examples.DummyObject); // <- this method doesn't need to know anything about DummyObject, only needs the int and string
            }

            // DO: Follow the regular naming guidelines in lambda expresions and auto-generated delegates

            void LambdaExpressionExample()
            {
                List<int> example = new List<int> ();

                // GOOD:
                example.FindAll(delegate (int _index)
                {
                    return _index > 2;
                });

                // BAD:
                example.FindAll(delegate (int _x)
                {
                    return _x > 2;
                });
            }

            // DO: Check input paramaters before assignment. Make sure that the values are reasonable
            // You can use asserts if you don't want this checks in your release versions in scenarios where performance is the priority
            void MethodParametersCheck(Example _exampleObject)
            {
                if(_exampleObject == null)
                {
                    Debug.LogError("The parameter _exampleObject can't be null");
                    return;
                }

                Debug.LogFormat("Status: {0}",_exampleObject.Status);
            }

            // ================================
            // 6.3 - Methods return value conventions
            // ================================

            // DO: Have a single return point in your method, this will help to maintain and debug your code.
            // An exception of this rule is when doing error handling at the beggining of a method

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

            // ================================
            // 6.4 Method considerations
            // ================================

            private void MethodsConsiderations()
            {
                // DO: methods must have a single purpose

                // DO: Try to avoid methods over 200 lines of code (comments and blank lines are excluded). There are a lot of studies with different results 
                // so there is not an official standard in the industry. Try to avoid large methods because usually, they are consequences of bad programming practices
                // but you can always write methods over 200 lines if you need it and they are simple enough to be readable, maintenable and undertestanable.
            }

        }

        // ###################################################################
        // 7 - Variable Conventions
        // ###################################################################
        
        private class VariableConventions
        {
            // ================================
            // 7.1 Variable Declarations
            // ================================

            private void VariableDeclarations()
            {
                // DO: Initialize all variables

                // GOOD: 
                int myInt = 0;
                GameObject myGameObject = null;

                // BAD:
                int anotherInt;
                GameObject targetGameobject;


                // DO: Initialize each variable close to where it's firts used to
                // preserve the Principle of Proximity: keep related actions together

                // GOOD:
                string id = example.DummyObject.ID;
                Debug.LogFormat("Id: {0}", id);

                string secondID = example.DummyObject.ID;
                Debug.LogFormat("secondID: {0}", secondID);


                // BAD:
                string sourceId = example.DummyObject.ID;
                string targetId = example.DummyObject.ID;

                Debug.LogFormat("SourceId: {0}", sourceId);
                Debug.LogFormat("TargetId: {0}", targetId);

                // CONSIDER: declaring and defining each variable where it's first used:

                // GOOD:
                Example.StatusEnum status1 = example.Status;

                // BAD:
                Example.StatusEnum status2 = Example.StatusEnum.Undefined;
                status2 = example.Status;

                // DO: Group related statements

                // GOOD:
                var dummyObject = example.DummyObject; // <-- Dummy Object
                bool dummyObjectOK = example.DoOperations(dummyObject); // <-- Operate over Dummy Object
                var oldDummyObject = example.OldDummyObject; // <-- Old Dummy Object
                bool oldDummyObjectOK = example.DoOperations(oldDummyObject); // <-- Operate over Old dummy object


                // DO NOT:
                var dummyObject1 = example.DummyObject; // <-- Dummy Object
                var oldDummyObject1 = example.OldDummyObject; // <-- Old Dummy Object
                bool oldDummyObjectOK1 = example.DoOperations(oldDummyObject1); // <-- Operate over Old dummy object
                bool dummyObjectOK1 = example.DoOperations(dummyObject1); // <-- Operate over Dummy Object

                // DO: Use each variable for one purpose only to improve readibility

                // GOOD:
                int randomIndex = example.GetRandomInt();
                Debug.LogFormat("Random Index: {0}", randomIndex);

                int score = example.CalculateScore();
                Debug.LogFormat("Score: {0}", score);

                // BAD:
                int tempValue = example.GetRandomInt();
                Debug.LogFormat("Random Index: {0}", tempValue);

                tempValue = example.CalculateScore();
                Debug.LogFormat("Score: {0}", tempValue);


                // DO NOT: Set variables with hidden meanings to avoid "hybrid coupling"

                // GOOD:
                var status = example.Status;
                if (status == Example.StatusEnum.Ok)
                {
                    int finalScore = example.CalculateScore();
                }
                else
                {
                    Debug.LogError("Some error occured. The game doesn't ended well");
                }

                // BAD:
                int gameOverScore = example.CalculateScore();
                if (gameOverScore == -1) // Two meanings for gameOverScore: game score & error 
                {
                    Debug.LogError("Some error occured. The game doesn't ended well");
                }


                // DO: Make sure all declared variables are used.
                // You can see Warnings in the console to remove unused variables.


                // DO: Use 'var' keyword in variable declarations where the type is obvious or isn't relevant. For example, with numeric variables
                // you CAN'T user var because it is important to know if you are working with ints or floats
                // - Code maintenance is improved
                // - Code readability is improved 
                // TODO: Discuss this with the team

                // GOOD:
                var target = example.DummyGameObject;

                // BAD:
                GameObject source = example.DummyGameObject;

                // With numeric values:

                // BAD:
                var totalPlays = 5;
                var totalScore = example.CalculateScore();
                var averageScore = totalScore / totalPlays; // <-- we can have errors because we don't know the type of the variables (float, int, etc)


                // Note (1): If you are concerned about performance, you can use Assertions (Unity Debug.Assert)
            }

            // ================================
            // 7.2 Variable Names
            // ================================

            private void VariableNames()
            {
                // DO: Try to avoid computer related terms and use problem domain terms.

                // GOOD:
                System.Object playerSaveGame = new System.Object();

                // BAD:
                System.Object savedData = new System.Object();

                // DO NOT: Use too short, too long, hard to type, hard to pronounce variable names

                // CONSIDER: Using variables with a name length: Between 8 and 20 characters
                // ABCDEFGH <-- 8 characters
                // ABCDEFGHIJKLMNOPQRST <-- 20 characters

                // DO: If the variable has a qualifer like: Total, Sum, Average, Max, Min, Record, String, Pointer, etc
                // put it at the end of the name

                // GOOD:
                int scoreTotal = 0;
                float healthAverage = 0;
                Text titleLabel = null;

                // DO: Use more detailed index names for nested loops to avoid index corss-talk errors (saying i when you mean j and vice versa)

                // GOOD:
                int[,] scores = new int[5, 5];
                int teamCount = 5;
                int eventCount = 5;
                for (int teamIndex = 0; teamIndex < teamCount; teamIndex++)
                {
                    for (int eventIndex = 0; eventIndex < eventCount; eventIndex++)
                    {
                        scores[teamIndex, eventIndex] = 0;
                    }
                }

                // DO: Give boolean variables names that imply true or false as: 
                // done, error, found, success, ok

                // DO: Use positive boolean variable names:

                // GOOD:
                bool found = false;

                // BAD:
                bool notFound = true;


                // DO NOT: Use names with ambiguous meanings

                // GOOD:
                {
                    int fileCount = 0;
                    int fileIndex = 1;
                }

                // BAD:
                {
                    int fileNumber = 0;
                    int fileIndex = 0;
                }


                // DO NOT: Use similar names in variables with different meaning

                // GOOD: 
                Rect screenArea = new Rect();
                Vector2 screenResolution = new Vector2();

                // BAD:
                Rect screenRect = new Rect();
                Vector2 screenRes = new Vector2();

                // DO: Avoid names that sound similar

                // DO NOT: Use numerals in names. If you feel you need numerals probably you need a different data type as an array

                // GOOD: 
                GameObject[] itemSlots = null;

                // BAD:
                GameObject itemSlot1 = null;
                GameObject itemSlot2 = null;
            }

            // ================================
            // 7.3 Numbers
            // ================================

            private void NumericVariables()
            {
                // DO: Avoid magic numbers

                // GOOD:
                float initialSpeed = 10f;
                float timeInSeconds = 60f;
                float fallSpeed = initialSpeed + Example.GRAVITY_ACCELERATION * timeInSeconds;

                // BAD:
                float fallSpeed1 = initialSpeed + 9.8f * timeInSeconds;

                // DO: Anticipate divide-by-zero errors

                // DO: Make data type conversions explicit in mathematical operations. 

                // GOOD:
                float x = 0f;
                int i = 0;
                float y = x + (float)i;

                // BAD:
                float w = x + i;

                // DO NOT: Use mixed-type comparisons

                // GOOD:
                if (i == (int)x)
                {

                }

                // BAD:
                if (i == x)
                {

                }

                // DO: Be careful with integer divisions
                float result = 10f * (7 / 10);  // <-- will return 0 in C#

                // CONSIDER: Integer overflow, you should think about the largest value your expression can assume.

                // DO NOT: add/substract on numbers that have greatly different magnitudes with float numbers
                float result1 = 1000000.00f + 0.1f; // <--  can have a result of 1,000,000.00

                // CONSIDER: The presence of accuracy errors in comparisons with floating-point numbers

                // GOOD:
                float maximumSpeed = 0f;
                float speed = 0f;
                if (maximumSpeed - speed < Example.SPEED_MAX_DELTA)
                {

                }

                // BAD:
                if (speed == maximumSpeed)
                {

                }
            }

            // ================================
            // 7.4 Characters And Strings
            // ================================

            private void CharacterAndStrings()
            {
                // DO: Avoid magic strings

                // GOOD:
                string localizedTitle = example.GetLocalizedText(Example.LOCALIZED_TITLE);

                // BAD:
                string localizedTitle1 = example.GetLocalizedText("TITLE_KEY");

                // DO: Use string.Format() to compose strings

                // GOOD:
                int score = 0;
                string finalText1 = string.Format("You have won {0} points", score);

                // BAD:
                string finalText2 = "You have won " + score + " points";

                // **** UNITY SPECIFICS ****

                // DO: Use Debug.LogFormat, Debug.LogErrorFormat & Debug.LogWarningFormat to print logs with composes messages

                // *************************

                // DO: Use string.IsNullOrEmpty to check for empty/null strings

                // GOOD:
                string userName = "";
                if (string.IsNullOrEmpty(userName))
                {

                }

                // BAD:
                if (userName == null || userName == "")
                {

                }

                // DO: Consider using the StringBuilder class if you need to work with long strings to reduce the impact on performance

                // GOOD:
                string text = null;
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                for (int i = 0; i < 100; i++)
                {
                    sb.AppendLine(i.ToString());
                }

                // BAD:
                for (int i = 0; i < 100; i++)
                {
                    text += i.ToString();
                }
            }

            // ================================
            // 7.5 Booleans
            // ================================

            private void Booleans()
            {
                // DO: Use boolean variables to increase readibility and maintenance in logic expressions 

                // GOOD:
                int elementIndex = 0;
                int lastElementIndex = 0;

                bool finished = ((elementIndex < 0) || (Example.MAX_ELEMENTS < elementIndex));
                bool repeatedEntry = (elementIndex == lastElementIndex);

                if (finished || repeatedEntry)
                {

                }

                // BAD:
                if ((elementIndex < 0) || (Example.MAX_ELEMENTS < elementIndex) || (elementIndex == lastElementIndex))
                {

                }
            }

            // ================================
            // 7.6 Enums
            // ================================

            // CONSIDER: Defining  the first value in an enum for an "invalid" value if it has sense with the purpose of the enum.
            // CONSIDER: Defining the last value of an enum if you are going to use it in iterations

            // GOOD:
            public enum GameModes
            {
                None,
                DeathMatch,
                TeamDeathMatch,
                CaptureTheFlag,
                End,
            }

            // **** UNITY SPECIFICS ****

            // DO NOT: Add new enum values in the middle of the enum, this will change the value of a serializable field in the Unity Inspector

            // GOOD:
            private enum GameModes1
            {
                None,
                DeathMatch,
                TeamDeathMatch,
                CaptureTheFlag,
                NewGameMode, // <-- Added at the end (before Final)
                Final,
            }

            // BAD:
            private enum GameModes2
            {
                None,
                DeathMatch,
                NewGameMode, // <-- Added in the middle, now the seralizable fields with the value of TeamDeatchMatch will have NewGameMode assigned
                TeamDeathMatch,
                CaptureTheFlag,
                Final,
            }

            // *************************

            
            private void UsingEnums()
            {
                // DO: Try to use the same enum values in external services to avoid name conversions

                // GOOD: 
                string gameModeString = example.GetGameModeFromServer();
                GameModes gameModeFromServer = (GameModes)Enum.Parse(typeof(GameModes), gameModeString);
                if (gameModeFromServer == GameModes.DeathMatch)
                {

                }

                // BAD:
                string gameModeString1 = example.GetGameModeFromServer();

                if (gameModeString1 == "DEATH_MATCH")
                {
                    gameModeFromServer = GameModes.DeathMatch;
                }
            }

            // ================================
            // 7.7 Arrays
            // ================================


            public void Arrays()
            {
                // DO: Check that array indexes are within the bounds of the array

                // GOOD:
                {
                    GameObject[] exampleArray = new GameObject[5];
                    int index = 0;
                    // index = NextIndex();
                    int maxLength = exampleArray.Length;

                    if (index >= maxLength)
                    {
                        Debug.LogErrorFormat("Array out of range. Index: {0} Max: {1}", index, maxLength);
                        index = maxLength - 1;
                    }

                    var myGameObject = exampleArray[index];
                }

                // BAD:
                {
                    GameObject[] exampleArray = new GameObject[5];
                    int index = 0;
                    // index = NextIndex();
                    int maxLength = exampleArray.Length;

                    var myGameObject = exampleArray[index];
                }

                // DO: Use lists if you don't know the size of the array, in other case, use arrays
            }

            private Example example = new Example();
        }

        // ###################################################################
        // 8 - Statements Conventions
        // ###################################################################
       
        private class StatementsConventions
        {
            // ===========================
            // 8.1 - Conditionals
            // ===========================

            private Example example = new Example();

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
                if (example.Status == Example.StatusEnum.Ok)
                {
                    // Normal case
                }
                else
                {

                }

                // BAD:
                if (example.Status != Example.StatusEnum.Ok)
                {
                    
                }
                else
                {
                    // Normal case
                }

                // CONSIDER: Consider to write the else clause to make clear to other programmers that you have considered that case

                // GOOD: 
                bool validID = !string.IsNullOrEmpty(example.DummyObject.ID);
                if (validID)
                {
                    // Normal case
                }
                else
                {
                    // If the id is not valid nothing happens here
                }

                // BAD: 
                if (validID)
                {
                    // Normal case
                }

                // DO: Simplify complicated tests with boolean functions calls

                // GOOD:
                bool statusIsOk = (example.Status == Example.StatusEnum.Ok);
                if(validID && statusIsOk)
                {
                    // Do something
                }

                // BAD:
                if (!string.IsNullOrEmpty(example.DummyObject.ID) && example.Status == Example.StatusEnum.Ok)
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

            // ===========================
            // 8.2 - Loops
            // ===========================

            public void Loops()
            {
                List<string> exampleNames = new List<string>();

                // DO: Put initialization code directly before the loop

                // EXAMPLE:
                bool enc    = false;
                int index   = 0;
                while (!enc)
                {
                    enc = exampleNames[index] == "Unnamed";
                    index++;
                }

                // **** UNITY SPECIFICS ****
                // DO: Prefer for loops instead of foreach loops if possible. For loops ar faster in Unity that foreach loops

                // GOOD:
                for (int i = 0; i < exampleNames.Count; i++)
                {
                    Debug.Log(exampleNames[i]);
                }

                // BAD:
                foreach(var name in exampleNames)
                {
                    Debug.Log(name);
                }

                // *************************

                // DO: When the number of iterations is indefinite, use a whille loop

                // DO: Use { and } to enclose statements in a loop always to prevent errors when code is modified.

                // GOOD:
                for (int i = 0; i < 100; i++)
                {
                    Debug.Log(i);
                }

                // BAD:
                for (int i = 0; i < 100; i++)
                    Debug.Log(i);

                // DO: Keep loop-housekeeping chores at either the beginning or the end of the loop

                // DO: Make each loop perform only one function. Loops should be like methods. 
                // An exception of this rule it is in places where performance is critical

                // DO: Make sure that a loop ends. This is specially important in some while loops that are potentially dangerous as infinite loops. 
                // Add maximum iterations counters or timers to avoid this problem.

                // GOOD:
                float securityTimer = 0f;
                while (example.Status != Example.StatusEnum.Ok && securityTimer < 10f)
                {
                    // Do something 

                    securityTimer += Time.deltaTime;
                }

                if(securityTimer >= 10f)
                {
                    Debug.Log("TimeOut");
                }

                // BAD:
                while (example.Status != Example.StatusEnum.Ok)
                {

                }

                // DO: If you need to use continue in a for loop, do it at the top of the loop

                // GOOD:
                for(int i = 0; i < 100; i++)
                {
                    if (example.Status != Example.StatusEnum.Ok)
                        continue;
                }

                // DO: Use meaningful variable names to make nested loops readable
                // Note: this is already seen in the section: 7.2 Variable Names

                // GOOD:
                for (int month = 0; month < 12; month++)
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

                // DO: Limit nesting of loop to three levels. Break the loops into methods if you need it to avoid this
            }
        }

        // ###################################################################
        // 9 - Comments conventions
        // ###################################################################

        private class CommentsConventions
        {
            private Example example = new Example();

            // DO: Write code that is enough clear to be a "self-documenting" code. If you have to write a comment just because the code is so complicated, 
            // it is better to improve the code that to write the comment

            // DO NOT: Write comments that repeats what the code does

            // DO: Write comments that summary the code to help other programmers at reading the code

            // DO: Write comments to describe the code's intent. Use always vocabulary in the domain of the problem instead of triying to describe the solution

            // GOOD:
            // get current employee information

            // BAD:
            // get employee object from database query

            // DO NOT: Leave big regions of code commented when you commit to developer. Use the version repository to see old code.

            // DO NOT: Leave comments until the end. You need to integrate commenting into your development style. This will help others in code reviews and also will help you
            // to think more about the problem you are triying to solve

            // DO: Use XML comments because the will be showed in the Intellisense.
            // DO NOT: Use endline comments.

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


            // BAD
            // Explain what this method does
            private void ExampleMethod3()
            {

            }


            // **** UNITY SPECIFICS ****
            // CONSIDER: Using Unity Tooltip atribute instead of comments to describe a variable if this variable is going to be modified in the editor and its meaning
            // isn't clear with the name.
            // This will replace the regular commenting style
            // GOOD
            [Tooltip("Use this variable to declare the maximum value of the player health. Useful when implementing penalties")]
            [SerializeField]
            public float maximumHealthClamp = 1f;
            // *********************

            // CONSIDER: Using endline comments to mark end of blocks in complex if/else nested blocks. By default, you should use your IDE matching brackets tool.

            // GOOD

            private void ExampleMethod3()
            {
                if (example.Status == Example.StatusEnum.Ok)
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

            // DO: Comment units of numeric data (no matter if the unit of the data form part of the variable name)

            // GOOD:

            public Vector3 spaceshipVelocity = Vector3.zero; // Spaceship velocity vector in meters per second

            // DO: Comment the range of allowable numeric values

            // GOOD:

            public float normalizedProgress = 0f; // Player normalized progress in this level between 0 and 1

            // CONSIDER: Commenting enums values if they are not obvious

            // DO: When commenting class members as methods and properties, use the default format in c# (automatically generated if you write ///)

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

        // ###################################################################
        // 10 - Unity Special Conventions
        // ###################################################################

        private class UnityConventions
        {
            Example example = new Example();

            private MonoBehaviour dummyComponent = null;

            // =================================
            // 10.1 - Coroutines
            // =================================

            // DO: If you have to wait for one frame, and you are not working with graphic stuff, use "yield return null" instead of "yield return new WaitForEndOfFrame()"
            // doing this you will avoid memory allocation in each execution of the loop

            // Note: It's important to know that  yield return null is not evaluated in the same moment than WaitForEndOfFrame(); 
            // https://answers.unity.com/questions/755196/yield-return-null-vs-yield-return-waitforendoffram.html

            // GOOD:
            IEnumerator WaitOneFrameGood()
            {
                while (true)
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

            // EXAMPLE:
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
                // If Close is called this coroutine will keep being called because it was launched in another GameObject (can happen with a singleton for example)
                while (true)
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

            // =================================
            // 10.2 - Field attributes
            // =================================

            // CONSIDER: When declaring variables that can be accesed from the Unity inspector, don't forget about Unity attributes. 
            // This attributes will improve the inspector readibility.

            // [Header("Header")] Useful to group related fields
            // [Space()] Useful to add extra space between groups of fields
            // [Range(min,max)]  Use this in floats, specially when you want a normalized value between 0 and 1f
            // [Tooltip("Tooltip description")] Can replace fields comments, this is also described in section 9 - Comments Conventions
        }
    }

    #region Example class, ignore it
    public class Example
    {
        public const float GRAVITY_ACCELERATION = 9.8f;

        public const float SPEED_MAX_DELTA = 0.1f;

        public const int MAX_ELEMENTS = 99;

        public const string LOCALIZED_TITLE = "TITLE_KEY";

        public enum StatusEnum
        {
            Undefined,
            Ok,
            Error,
            Interrupted
        }

        public DummyClass DummyObject { get; private set; }

        public DummyClass OldDummyObject { get; private set; }

        public GameObject DummyGameObject { get; private set; }

        public StatusEnum Status { get; private set; }

        public int dummyInt;

        public string dummyString;

        public bool DoOperations(DummyClass _dummyObject)
        {
            return true;
        }

        public int GetRandomInt()
        {
            return 0;
        }

        public int CalculateScore()
        {
            return 0;
        }

        public bool IsLetter(char _char)
        {
            return true;
        }

        public bool IsNumber(char _char)
        {
            return true;
        }
        public bool IsPunctiation(char _char)
        {
            return true;
        }

        public string GetLocalizedText(string _textKey)
        {
            return "";
        }

        public string GetGameModeFromServer()
        {
            return "";
        }

        public class DummyClass
        {
            public string ID { get; private set; }
        }

        public class MethodExamples
        {
            // Vague method name
            public void ComputeScore()
            {

            }

            // Good method name
            public void ComputeGameOverScore()
            {

            }

            // Good method name
            public void ComputeGameOverScoreAndUploadToServer()
            {

            }

            // method name without verb
            public void Score()
            {

            }

            public void GetScore()
            {

            }

            // Bad examples
            public string GetId()
            {
                return "";
            }

            public string Id()
            {
                return "";
            }

            public string ID { get; private set; }

            // Parameters order

            public void ConfigurePlayerSkin(bool _premiumSkins, ref GameObject _instantiatedPlayer, out GameObject _mainWeapon, out bool _error)
            {
                _error = false;
                _mainWeapon = new GameObject();
            }

            // Examples of methods to pass variables to maintain interface abstraction
            public void MethodWithGoodParameters(int _intParameter, string _stringParameter)
            {

            }

            public void MethodWithBadParameters(DummyClass _dummyObject)
            {

            }
        }

    }
    #endregion
}