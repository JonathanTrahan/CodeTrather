
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections.Generic;
using Code_Trather;
using System.Drawing.Text;

/// <summary>
/// Class that contains the global variables for the whole application 
/// </summary>
public static class Globals
{

    /// <summary>
    /// Variable that contains the first name of the student
    /// </summary>
    public static string fName = "";
    /// <summary>
    /// Variable that contains the last name of the student
    /// </summary>
    public static string lName = "";

    /// <summary>
    /// List of Hot Key word to check inputs for
    /// </summary>
    public static string[] hotKeys = { "Alt", "F11", "F12", "Insert", "Delete", "Control" , "Escape","LWin"};
    /// <summary>
    /// List of the Hot keys that wont be logged 
    /// </summary>
    public static string[] nonHotKeys = { "Menu", "ControlKey" };
    /// <summary>
    /// List of the used Hot Keys 
    /// </summary>
    public static List<string> usedHotKeys = new List<string> { };

    /// <summary>
    /// Makes a long list of every key press over a time interval
    /// </summary>
    public static string keyTracker = "";

    /// <summary>
    /// Counters - These keep track of what the log number is currently next
    /// </summary>
    public static int snapshotCounter = 1;
    public static int clipboardCounter = 1;
    public static int outputCounter = 1;
    public static int attentionCounter = 1;
    public static int errorCounter = 1;
    public static int pressCounter = 1;
    public static int keyloggerCounter = 1;
    public static int hotkeyCounter = 1;
    /// <summary>
    /// Addresses - FilePaths to a specified file or folder to be used by the program
    /// </summary>

    /// <summary>
    /// Log Folder addresses
    /// </summary>
    public static string filePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads/TratherLogs/";
    public static string snapshotsAddress = filePath + "snapshots.txt";
    public static string clipboardhtmlAddress = filePath + "clipboard.html";
    public static string downloadAddress = filePath + "Program.py";
    public static string downloadAddressJava = filePath + "Program.java";
    public static string javaUnitTestVersion = filePath + "Test/Program.java";
    public static string snapshothtmlAddress = filePath + "snapshots.html";
    public static string outputAddress = filePath + "output.html";
    public static string inputFilePath = "";
    public static string logcssAddress = filePath + "logs.css";
    public static string collapseAddress = filePath + "collapse.js";
    public static string attentionAddress = filePath + "attention.html";
    public static string errorAddress = filePath + "error.html";
    public static string keyloggerAddress = filePath + "keylogger.html";
    public static string hotkeyAddress = filePath + "hotkeys.html";
    public static string unitTestFilePath = filePath + "unitTest.py";
    public static string unitTestFilePathJava = filePath + "unitTest.java";
    public static string indexAddress = filePath + "index.html";
    /// <summary>
    ///  Crypt Folder Addresses
    /// </summary>
    /// <summary>
    ///  Downloads/Cryptog/
    /// </summary>
    public static string cryptFolder = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads/Cryptog/";
    /// <summary>
    /// Downloads/TratherLogs.zip
    /// </summary>
    public static string filePathZip = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads/TratherLogs.zip";
    /// <summary>
    /// Downloads/Cryptog/TratherLogs.katb
    /// </summary>
    public static string encryptedZip = cryptFolder + "TratherLogs.katb";
    /// <summary>
    /// Downloads/Cryptog/TratherLogs_decrypted.zip
    /// </summary>
    public static string decryptedZip = cryptFolder + "TratherLogs_decrypted.zip";

    //Files to be added - The are premade files to be added the log folder to assist the html log files
    public static string logFile = "a{\r\n  color: blue;\r\n} .showall{\r\n  font-size: 15px;\r\n} /* Style the button that is used to open and close the collapsible content */\r\n.collapsible {\r\n  background-color: #eee;\r\n  color: #444;\r\n  cursor: pointer;\r\n  padding: 18px;\r\n  width: 100%;\r\n  border: none;\r\n  text-align: left;\r\n  outline: none;\r\n  font-size: 15px;\r\n}\r\n\r\n/* Add a background color to the button if it is clicked on (add the .active class with JS), and when you move the mouse over it (hover) */\r\n.active, .collapsible:hover {\r\n  background-color: #ccc;\r\n}\r\n\r\n/* Style the collapsible content. Note: hidden by default */\r\n.content {\r\n  padding: 0 18px;\r\n  display: none;\r\n  overflow: hidden;\r\n  background-color: #f1f1f1;\r\n}\r\n.collapsible:after {\r\n  content: '\\02795'; /* Unicode character for \"plus\" sign (+) */\r\n  font-size: 13px;\r\n  color: white;\r\n  float: right;\r\n  margin-left: 5px;\r\n}\r\n\r\n.active:after {\r\n  content: \"\\2796\"; /* Unicode character for \"minus\" sign (-) */\r\n}";
    public static string collapseFile = "var coll = document.getElementsByClassName(\"collapsible\");\r\nvar i;\r\n\r\nfor (i = 0; i < coll.length; i++) {\r\n  coll[i].addEventListener(\"click\", function() {\r\n    this.classList.toggle(\"active\");\r\n    var content = this.nextElementSibling;\r\n    if (content.style.display === \"block\") {\r\n      content.style.display = \"none\";\r\n    } else {\r\n      content.style.display = \"block\";\r\n    }\r\n  });\r\n}  function ShowAll(){\r\n  for (let i = 0; i<coll.length;i++){\r\n      let bt = coll[i];\r\n      bt.click();\r\n    } \r\n} \r\n";


    public static string execSum = filePath + "ExecutiveSummary.csv";
    public static string errorString = "ArithmeticError AssertionError AttributeError BaseException BlockingIOError BrokenPipeError BufferError " +
                "BytesWarning ChildProcessError ConnectionAbortedError ConnectionError ConnectionRefusedError ConnectionResetError DeprecationWarning EOFError Ellipsis EnvironmentError Exception " +
                "FileExistsError FileNotFoundError FloatingPointError FutureWarning GeneratorExit IOError ImportError ImportWarning IndentationError IndexError InterruptedError IsADirectoryError " +
                "KeyError KeyboardInterrupt LookupError MemoryError ModuleNotFoundError NameError NotADirectoryError NotImplemented NotImplementedError OSError OverflowError PendingDeprecationWarning " +
                "PermissionError ProcessLookupError RecursionError ReferenceError ResourceWarning RuntimeError RuntimeWarning StopAsyncIteration StopIteration SyntaxError SyntaxWarning SystemError " +
                "SystemExit TabError TimeoutError TypeError UnboundLocalError UnicodeDecodeError UnicodeEncodeError UnicodeError UnicodeTranslateError UnicodeWarning UserWarning ValueError Warning " +
                "WindowsError ZeroDivisionError";
    public static List<string> errorList = errorString.Split(' ').ToList();
    public static List<string> words = new List<string>();

    /// <summary>
    /// Get function for creating the index file because it needs to be generated after student information is input
    /// </summary>
    /// <returns>File string with student information</returns>
    public static string getIndexFile()
    {
        return $"<!DOCTYPE html> \r\n<html> \r\n\t<!-- Inside head tags contain header information for the webpage-->\r\n\t<head>\r\n\t\t<!-- meta -  data about the document -->\r\n\t\t<meta charset=\"utf-8\">\r\n\t\t<meta name = \"description\" content=\"awesome content\">\r\n\t\t<link rel=\"stylesheet\" type=\"text/css\" href=\"./logs.css\">\r\n\t\t<!-- Title tag chenges the title in the web browser tab -->\r\n\t\t<title>\r\n\t\t\tStudent Log Landing Page\r\n\t\t</title>\r\n\r\n\t</head>\r\n\t<!-- Inside body tags contain the contents of the webpage-->\r\n\t<body>\r\n\t\t<header>\r\n\t\t\t<nav></nav>\r\n\t\t</header>\r\n\t\t\r\n\t\t<main>\r\n\t\t\t<h1>{Program.studentName}, {Program.cwid}, Log Page</h1>\r\n\t\t\t<p><big><big><big><b>Assignments</b></big></big></big></p>\r\n\t\t\t<big><big><ul>\r\n\t\t\t\t<li><a href=\"snapshots.html\" target=\"_blank\">Snapshot Log</a></li>\r\n\t\t\t\t<ul><li>Log with snapshots of code throughout the test</li></ul>\r\n\t\t\t\t<li><a href=\"attention.html\" target=\"_blank\">Attention Log</a></li>\r\n\t\t\t\t<ul><li>Log that tracks the user's attention throughout the test</li></ul>\r\n\t\t\t\t<li><a href=\"hotkeys.html\" target=\"_blank\">Hot Key Log</a></li>\r\n\t\t\t\t<ul><li>Log that tracks any special key presses throughout the test</li></ul>\r\n\t\t\t\t<li><a href=\"output.html\" target=\"_blank\">Output Log</a></li>\r\n\t\t\t\t<ul><li>Log of all outputs during the test</li></ul>\r\n\t\t\t\t<li><a href=\"error.html\" target=\"_blank\">Error Log</a></li>\r\n\t\t\t\t<ul><li>Log of all error outputs from testing the code</li></ul>\r\n\t\t\t\t<li><a href=\"clipboard.html\" target=\"_blank\">Clipboard Log</a></li>\r\n\t\t\t\t<ul><li>Log of the student's clipboard during the test</li></ul>\r\n\t\t\t\t<li><a href=\"keylogger.html\" target=\"_blank\">Key Logger Html</a></li>\r\n\t\t\t\t<ul><li>Log of all keys pressed during the test</li></ul>\r\n\t\t\t</ul></big></big>\r\n\t\t</main>\r\n\r\n\t</body>\r\n\r\n\r\n</html>";
    }
        // Time
    public static DateTime start = DateTime.Now;

    // HTML
    // Headers for html log files
    public static string getHeader(string title)
    {
        return $"<!DOCTYPE html> \n<html> \n\t<!-- Inside head tags contain header information for the webpage-->\n\t<head>\n\t\t<!-- meta -  data about the document -->\n\t\t<meta charset=\"utf-8\">\n\t\t<meta name = \"description\" content=\"awesome content\">\n        <link rel=\"stylesheet\" type=\"text/css\" href=\"./logs.css\">\n\t\t<!-- Title tag chenges the title in the web browser tab -->\n\t\t<title>\n\t\t\t {title} Log\n\t\t</title>\n\n\t</head>\n\t<!-- Inside body tags contain the contents of the webpage-->\n\t<body>\n\t\t\n\t\t\t<h1>{Program.studentName} {title} Log</h1><div><big><a  href=\"index.html\">Back to Landing Page</a></big></div><p></p><button type=\"button\" class=\"showall\" onclick =\"ShowAll()\">Toggle Logs</button>\r\n\t\t\t<p></p>";
    }
    /// <summary>
    /// Footer for the html log files
    /// </summary>
    public static string htmlFoot = "</body>\r\n\t<script src=\"./collapse.js\"></script>\r\n<style>\r\n.content {\r\n  padding: 0 18px;\r\n  background-color: white;\r\n  max-height: 0;\r\n  overflow: hidden;\r\n  transition: max-height 0.2s ease-out;\r\n}\r\n</style>\r\n\r\n<script>\r\nvar coll = document.getElementsByClassName(\"collapsible\");\r\nvar i;\r\n\r\nfor (i = 0; i < coll.length; i++) {\r\n  coll[i].addEventListener(\"click\", function() {\r\n    this.classList.toggle(\"active\");\r\n    var content = this.nextElementSibling;\r\n    if (content.style.maxHeight){\r\n      content.style.maxHeight = null;\r\n    } else {\r\n      content.style.maxHeight = content.scrollHeight + \"px\";\r\n    }\r\n  });\r\n}\r\n</script>\r\n\r\n</html>";

    /// <summary>
    /// Boolean to mark the project as complete
    /// </summary>
    public static bool DONE = false;

    /// <summary>
    /// Used to get the time elasped from the start of the project to the current time
    /// </summary>
    /// <returns> TimeSpan aka time between the start of the program and the current time</returns>
    public static TimeSpan timeElapsed()
    {
        DateTime current = DateTime.Now;

        TimeSpan ts = current - start;


        return ts;
    }

    /// <summary>
    /// Method that reads a list and returns a list that contains how many times a string was repeated in a list
    /// </summary>
    /// <param name="listToRead">List to be read for repeated values</param>
    /// <returns>List of repeated values and how many times they are repeated</returns>
    public static List<string> listReader(List<string> listToRead)
    {
        List<string> checkedlist = new List<string> { };
        List<string> instances = new List<string> { };


        foreach (string e in listToRead)
        {
            int temp = 0;
            bool contains = false;
            foreach (string k in checkedlist)
            {
                if (k == e)
                {
                    contains = true;
                }
            }
            if (!contains)
            {
                foreach (string m in listToRead)
                {
                    if (e == m)
                    {
                        temp++;
                    }
                }
                instances.Add($"{e}: {temp}");
                checkedlist.Add(e);
            }
        }
        return instances;
    }

}


