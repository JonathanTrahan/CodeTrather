
using System.Diagnostics;
using System.Timers;
using static ScintillaNET.Style;

/// <summary>
/// Class that handles most/all methods that have to do with writing to the log files 
/// </summary>
public class WriteTo
{

    /// <summary>
    /// Method to be run when the submit button is pressed. Will add tails to all the html files so that they are complete files.
    /// </summary>
    public static void Complete()
    {
        if (Globals.DONE == false)
        {
            writeToFile(Globals.keyloggerAddress, Globals.htmlFoot);
            writeToFile(Globals.snapshothtmlAddress, Globals.htmlFoot);
            writeToFile(Globals.clipboardhtmlAddress, Globals.htmlFoot);
            writeToFile(Globals.outputAddress, Globals.htmlFoot);
            writeToFile(Globals.attentionAddress, Globals.htmlFoot);
            writeToFile(Globals.errorAddress, Globals.htmlFoot);
            
            writeToFile(Globals.hotkeyAddress, Globals.htmlFoot);
        }
    }

    /// <summary>
    /// Method to write to a specific File 
    /// </summary>
    /// <param name="fileName">name of the file to be written to</param>
    /// <param name="write">string to be written to the file</param>
    public static void writeToFile(string fileName, string write)
    {
        File.AppendAllText(fileName, write + Environment.NewLine);
    }
   

    /// <summary>
    /// Method to replace all "\n" with "</div><div>" so that the logs are not all on one line
    /// </summary> 
    public static string addDiv(string text)
    {

        string temp = "<div>";
        text = text.ReplaceLineEndings("</div><div>");
        string temp2 = "</div>";
        text = temp + text + temp2;
        return text;
    }
    /// <summary>
    /// Replaces comma with a plus sign so that it can be put into a csv file
    /// </summary>
    /// <param name="text">text to be parsed for commas</param>
    /// <returns>text that had a comma now have a plus sign instead</returns>
    public static string addPlus(string text)
    {
        string[] textlist = text.Split(",");
        string newstring = "";
        newstring += textlist[0];
        newstring += " +";
        newstring += textlist[1];
        return newstring;

    }

    /// <summary>
    /// Method to clear the files if the exist and create the files if they don't
    /// </summary>
    public static void CreateFiles()
    {
        // Clears the text of the given file
        File.AppendAllText(Globals.snapshothtmlAddress, "");
        System.IO.File.WriteAllText(Globals.snapshothtmlAddress, string.Empty);
        // Writes the HTML header to the file
        WriteTo.writeToFile(Globals.snapshothtmlAddress, Globals.getHeader("Snapshot"));

        File.AppendAllText(Globals.clipboardhtmlAddress, "");
        System.IO.File.WriteAllText(Globals.clipboardhtmlAddress, string.Empty);
        WriteTo.writeToFile(Globals.clipboardhtmlAddress, Globals.getHeader("Clipboard"));

        File.AppendAllText(Globals.outputAddress, "");
        System.IO.File.WriteAllText(Globals.outputAddress, string.Empty);
        WriteTo.writeToFile(Globals.outputAddress, Globals.getHeader("Output"));

        File.AppendAllText(Globals.attentionAddress, "");
        System.IO.File.WriteAllText(Globals.attentionAddress, string.Empty);
        WriteTo.writeToFile(Globals.attentionAddress, Globals.getHeader("Attention"));

        File.AppendAllText(Globals.errorAddress, "");
        System.IO.File.WriteAllText(Globals.errorAddress, string.Empty);
        WriteTo.writeToFile(Globals.errorAddress, Globals.getHeader("Error"));

        File.AppendAllText(Globals.keyloggerAddress, "");
        System.IO.File.WriteAllText(Globals.keyloggerAddress, string.Empty);
        WriteTo.writeToFile(Globals.keyloggerAddress, Globals.getHeader("Key"));

        File.AppendAllText(Globals.hotkeyAddress, "");
        System.IO.File.WriteAllText(Globals.hotkeyAddress, string.Empty);
        WriteTo.writeToFile(Globals.hotkeyAddress, Globals.getHeader("Hot Key"));

        // Creates premade files to the log folder
        File.AppendAllText(Globals.logcssAddress, "");
        System.IO.File.WriteAllText(Globals.logcssAddress, string.Empty);
        WriteTo.writeToFile(Globals.logcssAddress, Globals.logFile);

        // Creates premade files to the log folder
        File.AppendAllText(Globals.collapseAddress, "");
        System.IO.File.WriteAllText(Globals.collapseAddress, string.Empty);
        WriteTo.writeToFile(Globals.collapseAddress, Globals.collapseFile);

        // Creates premade landing page to the log folder
        File.AppendAllText(Globals.indexAddress, "");
        System.IO.File.WriteAllText(Globals.indexAddress, string.Empty);
        WriteTo.writeToFile(Globals.indexAddress, Globals.getIndexFile());
    }

    /// <summary>
    /// Method to write to the Snapshot HTML log file
    /// </summary>
    /// <param name="write">text to be written to to the log file</param>
    public static void writeToSnapshotHTML(string write)
    {
        // If project is not complete then update log file
        if (Globals.DONE == false)
        {
            // Address of the file that will be written to
            string address = Globals.snapshothtmlAddress;
            // String that will be written to the file
            string log = $"<button type=\"button\" class=\"collapsible\">Log #{Globals.snapshotCounter} ; {DateTime.Now.ToString("hh:mm:ss tt")} ; {Globals.timeElapsed().ToString().Remove(8)} time elapsed</button>\r\n\t\t\t<div class=\"content\">\r\n\t\t\t  <p>{addDiv(write)}</p>\r\n\t\t\t</div>";
            writeToFile(address, log);
            // Increments the counter so that the Counter is up to date
            Globals.snapshotCounter += 1;
        }
    }

    /// <summary>
    /// Method to write to the Key Logger HTML log file
    /// </summary>
    /// <param name="write">text to be written to to the log file</param>
    public static void writeToKeyLoggerHTML(string write)
    {
        // If project is not complete then update log file
        if (Globals.DONE == false)
        {
            // Address of the file that will be written to
            string address = Globals.keyloggerAddress;
            // String that will be written to the file
            string log = $"<button type=\"button\" class=\"collapsible\">Log #{Globals.keyloggerCounter} ; {DateTime.Now.ToString("hh:mm:ss tt")} ; {Globals.timeElapsed().ToString().Remove(8)} time elapsed</button>\r\n\t\t\t<div class=\"content\">\r\n\t\t\t  <p>{addDiv(write)}</p>\r\n\t\t\t</div>";
            writeToFile(address, log);
            // Increments the counter so that the Counter is up to date
            Globals.keyloggerCounter += 1;
        }
    }
    /// <summary>
    /// Method to write to the Hot Key Logger HTML log file
    /// </summary>
    /// <param name="write">text to be written to to the log file</param>
    public static void writeToHotKeyHTML(string write)
    {
        // If project is not complete then update log file
        if (Globals.DONE == false)
        {
            // Address of the file that will be written to
            string address = Globals.hotkeyAddress;
            // String that will be written to the file
            string log = $"<button type=\"button\" class=\"collapsible\">Log #{Globals.hotkeyCounter} ; {DateTime.Now.ToString("hh:mm:ss tt")} ; {Globals.timeElapsed().ToString().Remove(8)} time elapsed</button>\r\n\t\t\t<div class=\"content\">\r\n\t\t\t  <p>{addDiv(write)}</p>\r\n\t\t\t</div>";
            writeToFile(address, log);
            // Increments the counter so that the Counter is up to date
            Globals.hotkeyCounter += 1;
            Globals.usedHotKeys.Add(write);
        }
    }
    /// <summary>
    /// Method to write to the Clipboard HTML log file 
    /// </summary>
    /// <param name="write">text to be written to to the log file</param>
    public static void writeToClipboard(string write)
    {
        // If project is not complete then update log file
        if (Globals.DONE == false)
        {
            // If there is nothing in the clipboard don't log anything
            if (write != "")
            {
                // Address of the file that will be written to
                string address = Globals.clipboardhtmlAddress;
                // String that will be written to the file
                string log = $"<button type=\"button\" class=\"collapsible\">Log #{Globals.clipboardCounter} ; {DateTime.Now.ToString("hh:mm:ss tt")} ; {Globals.timeElapsed().ToString().Remove(8)} time elapsed</button>\r\n\t\t\t<div class=\"content\">\r\n\t\t\t  <p>{addDiv(write)}</p>\r\n\t\t\t</div>";
                writeToFile(address, log);
                // Increments the counter so that the Counter is up to date
                Globals.clipboardCounter += 1;
            }
        }
    }

    /// <summary>
    /// Method to write to the Output HTML log file
    /// </summary>
    /// <param name="write">text to be written to to the log file</param>
    public static void writeToOutput(string write)
    {
        // If project is not complete then update log file
        if (Globals.DONE == false)
        {
            // Address of the file that will be written to
            string address = Globals.outputAddress;
            // String that will be written to the file
            string log = $"<button type=\"button\" class=\"collapsible\">Log #{Globals.outputCounter} ; {DateTime.Now.ToString("hh:mm:ss tt")} ; {Globals.timeElapsed().ToString().Remove(8)} time elapsed</button>\r\n\t\t\t<div class=\"content\">\r\n\t\t\t  <p>{addDiv(write)}</p>\r\n\t\t\t</div>";
            writeToFile(address, log);
            // Increments the counter so that the Counter is up to date
            Globals.outputCounter += 1;
        }
    }

    /// <summary>
    /// Method to write to the Attention HTML log file
    /// </summary>
    /// <param name="write">text to be written to to the log file</param>
    public static void writeToAttention(string write)
    {
        // If project is not complete then update log file
        if (Globals.DONE == false)
        {
            // Address of the file that will be written to
            string address = Globals.attentionAddress;
            // String that will be written to the file
            string log = $"<button type=\"button\" class=\"collapsible\">Log #{Globals.attentionCounter} ; {DateTime.Now.ToString("hh:mm:ss tt")} ; {Globals.timeElapsed().ToString().Remove(8)} time elapsed</button>\r\n\t\t\t<div class=\"content\">\r\n\t\t\t  <p>{addDiv(write)}</p>\r\n\t\t\t</div>";
            writeToFile(address, log);
            // Increments the counter so that the Counter is up to date
            Globals.attentionCounter += 1;
        }
    }

    /// <summary>
    /// Method to write to the Error HTML log file
    /// </summary>
    /// <param name="write">text to be written to to the log file</param>
    public static void writeToError(string write)
    {
        // If project is not complete then update log file
        if (Globals.DONE == false)
        {
            // Address of the file that will be written to
            string address = Globals.errorAddress;
            // String that will be written to the file
            string log = $"<button type=\"button\" class=\"collapsible\">Log #{Globals.errorCounter} ; {DateTime.Now.ToString("hh:mm:ss tt")} ; {Globals.timeElapsed().ToString().Remove(8)} time elapsed</button>\r\n\t\t\t<div class=\"content\">\r\n\t\t\t  <p>{addDiv(write)}</p>\r\n\t\t\t</div>";
            writeToFile(address, log);
            // Increments the counter so that the Counter is up to date
            Globals.errorCounter += 1;
        }
    }


}
