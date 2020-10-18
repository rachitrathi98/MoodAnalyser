using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace MoodAnalyser
{
    public class MoodAnalyserFactory
    {
        /// <summary>
        /// UC4: Creates the mood analyser object with default constructor
        /// </summary>
        /// <param name="className">Name of the class.</param>
        /// <param name="constructor">The constructor.</param>
        /// <returns></returns>
        /// <exception cref="MoodAnalyserCustomException">
        /// class not found
        /// or
        /// constructor not found
        /// </exception>
        public static object CreateMoodAnalyserObject(string className, string constructor)
        {
            string pattern = @"." + constructor + "$";
            var result = Regex.Match(className, pattern);
            if (result.Success)
            {
                try
                {
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    Type moodAnalyserType = assembly.GetType(className);
                    var res = Activator.CreateInstance(moodAnalyserType);
                    return res;
                }
                catch (NullReferenceException)
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_CLASS, "class not found");
                }
            }
            else
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_CONSTRUCTOR, "constructor not found");
            }
        }
        /// <summary>
        /// UC5: Creates the mood analyser object with parameterized constructor.
        /// </summary>
        /// <param name="className">Name of the class.</param>
        /// <param name="constructor">The constructor.</param>
        /// <param name="message">The message.</param>
        /// <returns></returns>
        /// <exception cref="MoodAnalyserCustomException">
        /// constructor not found
        /// or
        /// class not found
        /// </exception>
        public static object CreateMoodAnalyserParameterizedObject(string className, string constructor, string message)
        {
            Type type = typeof(AnalyseMood);

            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {
                if (type.Name.Equals(constructor))
                {
                    ConstructorInfo construt = type.GetConstructor(new[] { typeof(string) });
                    Object obj = construt.Invoke(new object[] { message });
                    return obj;
                }
                else
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_CONSTRUCTOR, "constructor not found");
            }
            else
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_CLASS, "class not found");
            }
        }
        /// <summary>
        /// UC6: Using Reflection Invokes the analyser method.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="methodName">Name of the method.</param>
        /// <returns></returns>
        /// <exception cref="MoodAnalyserCustomException">method not found</exception>
        public static string InvokeAnalyserMethod(string message, string methodName)
        {
            try
            {
                Type type = Type.GetType("MoodAnalyser.AnalyseMood");
                MethodInfo methodInfo = type.GetMethod(methodName);
                object moodAnalyserObject = CreateMoodAnalyserParameterizedObject("MoodAnalyser.AnalyseMood", "AnalyseMood", message);
                object info = methodInfo.Invoke(moodAnalyserObject,null);
                return info.ToString();
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_METHOD, "method not found");
            }
        }
        /// <summary>
        /// UC7: Sets the field to change the mood dynamically.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="fieldName">Name of the field.</param>
        /// <returns></returns>
        /// <exception cref="MoodAnalyserCustomException">
        /// Message should not be null
        /// or
        /// Field is not found
        /// </exception>
        public static string SetField(string message, string fieldName)
        {
            try
            {
                AnalyseMood analyseMood = new AnalyseMood();
                Type type = typeof(AnalyseMood);
                FieldInfo field = type.GetField(fieldName, BindingFlags.NonPublic | BindingFlags.Instance);
                if (message == null)
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NULL_MESSAGE, "Message should not be null");
                }
                field.SetValue(analyseMood, message);
                return analyseMood.inputMessage;
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_FIELD, "Field is not found");
            }
        }
    }
}
