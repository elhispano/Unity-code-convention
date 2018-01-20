using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CodeConventions
{
    public class CodeConventionContentForExamples
    {
        public enum StatusEnum
        {
            Undefined,
            Ok,
            Error,
            Interrupted
        }
        public class DummyClass
        {
            public string ID { get; private set; }
        }

        public DummyClass DummyObject { get; private set; }

        public StatusEnum Status { get; private set; }

        public int dummyInt;

        public string dummyString;

        public class MethodExamples
        {
            // Vague routine name
            public void ComputeScore()
            {

            }

            // Good routine name
            public void ComputeGameOverScore()
            {

            }

            // Routine name without verb
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

            public void ConfigurePlayerSkin(bool _premiumSkins,ref GameObject _instantiatedPlayer,out GameObject _mainWeapon,out bool _error)
            {
                _error = false;
                _mainWeapon = new GameObject();
            }

            // Examples of methods to pass variables to maintain interface abstraction
            public void MethodWithGoodParameters(int _intParameter,string _stringParameter)
            {

            }

            public void MethodWithBadParameters(DummyClass _dummyObject)
            {

            }
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
    }
}
