using System.Collections;
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
    public class CodeConventionForUnity {

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

            public class NestedClass
            {
                public int exampleInt = 0;
            }
            #endregion

            #region TEST
            public void ClassNames()
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

            public void ClassConsiderations()
            {
                // 1
                // Provide services in pairs with their opposites

                // 2
                // Move unrelated information to another class

                // 3
                // Don’t expose member data in public

                // 4
                // Minimize accessibility of classes and members (hide as much information as possible)

                // 5
                // Keep the number of routines in a class as small as possible

                // 6
                // Avoid deep inheritance trees

                // 7
                // Try to preserve the Law of Demeter which helps to keep low the coupling of the class with other classes:
                // Each unit should have only limited knowledge about other units: only units "closely" related to the current unit.
                // Following this principle implies avoiding this kind of lines: otherClass.otherComponent.whateverThing.transform.position
            }
        }


        public class VariableConventions
        {
            public void VariableNames()
            {

            }

            public void BooleansConsiderations()
            {

            }
        }

        public class EventConventions
        {
            // TODO: Meter mas caña a los eventos con la guia de microsoft
            // https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/names-of-type-members
            // en esta guia tb habla de propiedades 
        }

        public class PropertiesConventions
        {
            // TODO: Meter mas caña a los eventos con la guia de microsoft
            // https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/names-of-type-members
            // en esta guia tb habla de propiedades 
        }

        public class RoutineConventions
        {

        }

        public class StatementsConventions
        {
            public void Conditionals()
            {

            }

            public void Loops()
            {

            }

            public void UnusualCOntrolStructures()
            {

            }

            public void ArrayMethods()
            {

            }
        }

        public class Comments
        {

        }

        private class GeneralConsiderations
        {
            // Favor read-time convenience to write-time convenience
        }
    }
}