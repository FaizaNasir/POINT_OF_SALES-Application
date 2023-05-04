/*
* MATLAB Compiler: 6.0 (R2015a)
* Date: Sun Apr 17 17:37:23 2016
* Arguments: "-B" "macro_default" "-W"
* "dotnet:TrainFunctioWithPATHLatesAndFinal,Class1,0.0,private" "-T" "link:lib" "-d"
* "D:\FYP Work\NEW WORK\Ver 1.0-----10 Products\Pouchs Excluded\Extract Features
* WORK\WithPath\TrainFunctioWithPATHLatesAndFinal\for_testing" "-v" "class{Class1:D:\FYP
* Work\NEW WORK\Ver 1.0-----10 Products\Pouchs Excluded\Extract Features
* WORK\WithPath\TrainFunction.m}" 
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace TrainFunctioWithPATHLatesAndFinal
{

  /// <summary>
  /// The Class1 class provides a CLS compliant, MWArray interface to the MATLAB
  /// functions contained in the files:
  /// <newpara></newpara>
  /// D:\FYP Work\NEW WORK\Ver 1.0-----10 Products\Pouchs Excluded\Extract Features
  /// WORK\WithPath\TrainFunction.m
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class Class1 : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB runtime instance.
    /// </summary>
    static Class1()
    {
      if (MWMCR.MCRAppInitialized)
      {
        try
        {
          Assembly assembly= Assembly.GetExecutingAssembly();

          string ctfFilePath= assembly.Location;

          int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

          ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

          string ctfFileName = "TrainFunctioWithPATHLatesAndFinal.ctf";

          Stream embeddedCtfStream = null;

          String[] resourceStrings = assembly.GetManifestResourceNames();

          foreach (String name in resourceStrings)
          {
            if (name.Contains(ctfFileName))
            {
              embeddedCtfStream = assembly.GetManifestResourceStream(name);
              break;
            }
          }
          mcr= new MWMCR("",
                         ctfFilePath, embeddedCtfStream, true);
        }
        catch(Exception ex)
        {
          ex_ = new Exception("MWArray assembly failed to be initialized", ex);
        }
      }
      else
      {
        ex_ = new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the Class1 class.
    /// </summary>
    public Class1()
    {
      if(ex_ != null)
      {
        throw ex_;
      }
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~Class1()
    {
      Dispose(false);
    }


    /// <summary>
    /// Frees the native resources associated with this object
    /// </summary>
    public void Dispose()
    {
      Dispose(true);

      GC.SuppressFinalize(this);
    }


    /// <summary internal= "true">
    /// Internal dispose function
    /// </summary>
    protected virtual void Dispose(bool disposing)
    {
      if (!disposed)
      {
        disposed= true;

        if (disposing)
        {
          // Free managed resources;
        }

        // Free native resources
      }
    }


    #endregion Finalize

    #region Methods

    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the TrainFunction MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// [row col] = size(INPUT_FEATURES);
    /// inp=30;   Number of Inputs / Features
    /// N1=20;    Number of Neurons
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TrainFunction()
    {
      return mcr.EvaluateFunction("TrainFunction", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the TrainFunction MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// [row col] = size(INPUT_FEATURES);
    /// inp=30;   Number of Inputs / Features
    /// N1=20;    Number of Neurons
    /// </remarks>
    /// <param name="path">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TrainFunction(MWArray path)
    {
      return mcr.EvaluateFunction("TrainFunction", path);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the TrainFunction MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// [row col] = size(INPUT_FEATURES);
    /// inp=30;   Number of Inputs / Features
    /// N1=20;    Number of Neurons
    /// </remarks>
    /// <param name="path">Input argument #1</param>
    /// <param name="N1">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TrainFunction(MWArray path, MWArray N1)
    {
      return mcr.EvaluateFunction("TrainFunction", path, N1);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the TrainFunction MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// [row col] = size(INPUT_FEATURES);
    /// inp=30;   Number of Inputs / Features
    /// N1=20;    Number of Neurons
    /// </remarks>
    /// <param name="path">Input argument #1</param>
    /// <param name="N1">Input argument #2</param>
    /// <param name="alpha">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TrainFunction(MWArray path, MWArray N1, MWArray alpha)
    {
      return mcr.EvaluateFunction("TrainFunction", path, N1, alpha);
    }


    /// <summary>
    /// Provides a single output, 4-input MWArrayinterface to the TrainFunction MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// [row col] = size(INPUT_FEATURES);
    /// inp=30;   Number of Inputs / Features
    /// N1=20;    Number of Neurons
    /// </remarks>
    /// <param name="path">Input argument #1</param>
    /// <param name="N1">Input argument #2</param>
    /// <param name="alpha">Input argument #3</param>
    /// <param name="epoch">Input argument #4</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TrainFunction(MWArray path, MWArray N1, MWArray alpha, MWArray epoch)
    {
      return mcr.EvaluateFunction("TrainFunction", path, N1, alpha, epoch);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the TrainFunction MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// [row col] = size(INPUT_FEATURES);
    /// inp=30;   Number of Inputs / Features
    /// N1=20;    Number of Neurons
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TrainFunction(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "TrainFunction", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the TrainFunction MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// [row col] = size(INPUT_FEATURES);
    /// inp=30;   Number of Inputs / Features
    /// N1=20;    Number of Neurons
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="path">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TrainFunction(int numArgsOut, MWArray path)
    {
      return mcr.EvaluateFunction(numArgsOut, "TrainFunction", path);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the TrainFunction MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// [row col] = size(INPUT_FEATURES);
    /// inp=30;   Number of Inputs / Features
    /// N1=20;    Number of Neurons
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="path">Input argument #1</param>
    /// <param name="N1">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TrainFunction(int numArgsOut, MWArray path, MWArray N1)
    {
      return mcr.EvaluateFunction(numArgsOut, "TrainFunction", path, N1);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the TrainFunction MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// [row col] = size(INPUT_FEATURES);
    /// inp=30;   Number of Inputs / Features
    /// N1=20;    Number of Neurons
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="path">Input argument #1</param>
    /// <param name="N1">Input argument #2</param>
    /// <param name="alpha">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TrainFunction(int numArgsOut, MWArray path, MWArray N1, MWArray 
                             alpha)
    {
      return mcr.EvaluateFunction(numArgsOut, "TrainFunction", path, N1, alpha);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the TrainFunction MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// [row col] = size(INPUT_FEATURES);
    /// inp=30;   Number of Inputs / Features
    /// N1=20;    Number of Neurons
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="path">Input argument #1</param>
    /// <param name="N1">Input argument #2</param>
    /// <param name="alpha">Input argument #3</param>
    /// <param name="epoch">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TrainFunction(int numArgsOut, MWArray path, MWArray N1, MWArray 
                             alpha, MWArray epoch)
    {
      return mcr.EvaluateFunction(numArgsOut, "TrainFunction", path, N1, alpha, epoch);
    }


    /// <summary>
    /// Provides an interface for the TrainFunction function in which the input and
    /// output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// [row col] = size(INPUT_FEATURES);
    /// inp=30;   Number of Inputs / Features
    /// N1=20;    Number of Neurons
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void TrainFunction(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("TrainFunction", numArgsOut, ref argsOut, argsIn);
    }



    /// <summary>
    /// This method will cause a MATLAB figure window to behave as a modal dialog box.
    /// The method will not return until all the figure windows associated with this
    /// component have been closed.
    /// </summary>
    /// <remarks>
    /// An application should only call this method when required to keep the
    /// MATLAB figure window from disappearing.  Other techniques, such as calling
    /// Console.ReadLine() from the application should be considered where
    /// possible.</remarks>
    ///
    public void WaitForFiguresToDie()
    {
      mcr.WaitForFiguresToDie();
    }



    #endregion Methods

    #region Class Members

    private static MWMCR mcr= null;

    private static Exception ex_= null;

    private bool disposed= false;

    #endregion Class Members
  }
}
