/*
* MATLAB Compiler: 6.0 (R2015a)
* Date: Sun Feb 14 18:09:46 2016
* Arguments: "-B" "macro_default" "-W" "dotnet:webcam_app,Class1,0.0,private" "-T"
* "link:lib" "-d" "D:\FYP Work\NEW WORK\Creating WebCamApp\webcam_app\for_testing" "-v"
* "class{Class1:D:\FYP Work\NEW WORK\Creating WebCamApp\webcam_app.m}" "-a" "D:\FYP
* Work\NEW WORK\Creating WebCamApp\camerashot.wav" "-a"
* "C:\MATLAB\SupportPackages\R2015a\osgenericvideointerface" "-a"
* "C:\MATLAB\SupportPackages\R2015a\dcamhardware" 
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace webcam_app
{

  /// <summary>
  /// The Class1 class provides a CLS compliant, MWArray interface to the MATLAB
  /// functions contained in the files:
  /// <newpara></newpara>
  /// D:\FYP Work\NEW WORK\Creating WebCamApp\webcam_app.m
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

          string ctfFileName = "webcam_app.ctf";

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
    /// Provides a single output, 0-input MWArrayinterface to the webcam_app MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// figure('Units', 'pixels', 'Position', [100 100 340 260]);
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray webcam_app()
    {
      return mcr.EvaluateFunction("webcam_app", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the webcam_app MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// figure('Units', 'pixels', 'Position', [100 100 340 260]);
    /// </remarks>
    /// <param name="baseDir_arg">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray webcam_app(MWArray baseDir_arg)
    {
      return mcr.EvaluateFunction("webcam_app", baseDir_arg);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the webcam_app MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// figure('Units', 'pixels', 'Position', [100 100 340 260]);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] webcam_app(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "webcam_app", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the webcam_app MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// figure('Units', 'pixels', 'Position', [100 100 340 260]);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="baseDir_arg">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] webcam_app(int numArgsOut, MWArray baseDir_arg)
    {
      return mcr.EvaluateFunction(numArgsOut, "webcam_app", baseDir_arg);
    }


    /// <summary>
    /// Provides an interface for the webcam_app function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// figure('Units', 'pixels', 'Position', [100 100 340 260]);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void webcam_app(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("webcam_app", numArgsOut, ref argsOut, argsIn);
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
