using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This file is organized in different classes, each class is a collection of guidelines.
// The file has a top-down organization from more general to more concrete things
// Summary - quick overview of conventions
// Class conventions
// Routine conventions
// Variable conventions
// Statements conventions
// Commenting conventions

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

            // classVariable: Member variables that are available to multiple routines within a class (1)(2)

            // _routineParameter: Routine parameters are formatted the same as local variables but they are preceded with an under slash

            // RoutineName(): Routines are in mixed uppercase and lowercase.

            // CONSTANT_VAR: Named constants are in ALL_CAPS.

            // readonly STATIC_VAR: Sometimes we need to use readonly static instead of constant when the initialization of the var requires an operation. 
            // in this case we use the same convention as constants vars

            // TODO: Share this with others programers, i have never use something like this but i whink is a good idea.
            // staticVarName: we use static prefix to make it clear the variable is static.

            // PropertyName: Because properties are indeed methods, we use the same convention

            // **** UNITY SPECIFICS ****

            // varNamePrefab: When a variable is a reference to a prefab, we concat the prefab keyword at the end of the variable name. We do this is to avoid
            // modifying a prefab by error.

            // varNameTemplate: When a variable is a reference to some component in the hierachy with the intention of being copied using Instantiate(varNameTemplate),
            // we add Template keyword at the end, with this we can see quickly if we are doing an invalid operation against a template (like destroying it!)

            // cachedComponentName: Use this to cached unity components like cachedTransform, cachedAnimator, etc.  

            // *************************

            // NOTES:
            // (1) We don't need to differentiate between local vars and class vars because we usually has different names. In case you need it you always can use this.varName 
            // to differentiate between two vars.
        }
    }

    public class ClassConventions
    {
        public void ClassOrder()
        {

        }

        #region TEST
        public void ClassNames()
        {
            // https://msdn.microsoft.com/en-us/library/4xhs4564(v=vs.71).aspx


            // SOME ADVISES
            // ************
        }
        #endregion

        public void ClassConsiderations()
        {
            // Provide services in pairs with their opposites
            // Move unrelated information to another class In

            //            Minimize accessibility of classes and members Minimizing accessibility is one of
            //several rules that are designed to encourage encapsulation. If you’re wondering
            //whether a specific routine should be public, private, or protected, one school of
            //thought is that you should favor the strictest level of privacy that’s workable(Meyers
            //1998, Bloch 2001). I think that’s a fine guideline, but I think the more important
            //guideline is, “What best preserves the integrity of the interface abstraction?” If exposing
            //the routine is consistent with the abstraction, it’s probably fine to expose it.If
            //you’re not sure, hiding more is generally better than hiding less

            // Don’t expose member data in public
        }
    }

    public class RoutineConventions
    {

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
}
