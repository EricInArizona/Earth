// Copyright Eric Chauvin 2019.


using System;
using System.Text;
using System.Collections.Generic;
using System.IO;



namespace ClimateModel
{
  class NotesDictionary
  {
  private MainForm MForm;
  private Dictionary<string, NotesRecord> CDictionary;
  private string FileName;


  public struct NotesRecord
    {
    // public string SeeAlso;
    // public string MainText;

    }


  private NotesDictionary()
    {
    }



  internal NotesDictionary( string FileToUseName, MainForm UseForm )
    {
    MForm = UseForm;

    FileName = FileToUseName;
    CDictionary = new Dictionary<string, NotesRecord>();


    // ReadFromTextFile();
    }


/*
NotesRecord
  internal string GetString( string KeyWord )
    {
    KeyWord = KeyWord.ToLower().Trim();

    string Value;
    if( CDictionary.TryGetValue( KeyWord, out Value ))
      return Value;
    else
      return "";

    }
*/




  internal void SetRecord( string KeyWord, NotesRecord Value )
    {
    KeyWord = KeyWord.ToLower().Trim();

    if( KeyWord == "" )
      {
      MForm.ShowStatus( "Can't add an empty keyword to the dictionary in ConfigureFile.cs." );
      return;
      }

    CDictionary[KeyWord] = Value;
    }



/*
  private bool ReadFromTextFile()
    {
    // AESEncryption AESEncrypt = null;

    CDictionary.Clear();
    if( !File.Exists( FileName ))
      return false;

    try
    {
    using( StreamReader SReader = new StreamReader( FileName, Encoding.UTF8 ))
      {
      while( SReader.Peek() >= 0 )
        {
        string Line = SReader.ReadLine();
        if( Line == null )
          continue;

        Line = Line.Trim();
        if( Line == "" )
          continue;

        // if( !Line.Contains( "\t" ))
          // Line = AESEncrypt.DecryptString( Line );

        if( !Line.Contains( "\t" ))
          continue;

        string[] SplitString = Line.Split( new Char[] { '\t' } );
        if( SplitString.Length < 2 )
          continue;

        string KeyWord = SplitString[0].Trim();
        string Value = SplitString[1].Trim();
        KeyWord = KeyWord.Replace( "\"", "" );
        Value = Value.Replace( "\"", "" );

        if( KeyWord == "" )
          continue;

        CDictionary[KeyWord] = Value;
        // try
        // CDictionary.Add( KeyWord, Value );
        }
      }

    return true;
    }
    catch( Exception Except )
      {
      MForm.ShowStatus( "Could not read the file: \r\n" + FileName );
      MForm.ShowStatus( Except.Message );
      return false;
      }
    }
*/



/*
  internal bool WriteToTextFile()
    {
    try
    {
    using( StreamWriter SWriter = new StreamWriter( FileName, false, Encoding.UTF8 ))
      {
      foreach( KeyValuePair<string, string> Kvp in CDictionary )
        {
        string Line = Kvp.Key + "\t" + Kvp.Value;
        // Line = AESEncrypt.EncryptString( Line );
        SWriter.WriteLine( Line );
        }

      SWriter.WriteLine( " " );
      }

    return true;
    }
    catch( Exception Except )
      {
      MForm.ShowStatus( "Could not write the configuration data to the file." );
      MForm.ShowStatus( Except.Message );
      return false;
      }
    }
*/



  /*
  private int GetIntegerValue( string Key )
    {
    try
    {
    return Int32.Parse( Config.GetString( Key ));
    }
    catch( Exception ) // Except )
      {
      // MForm.ShowStatus( "Exception in GetIntegerValue():" );
      // MForm.ShowStatus( Except.Message );
      return -1;
      }
    }
    */


  /*
  private void SetIntegerValue( string Key, int ToSet )
    {
    SetString( Key, ToSet.ToString() );
    WriteToTextFile();
    }
    */


/*
============
  private void AddRecords()
    {
    string KeyWord = "";
    NotesRecord Rec;



    Rec = new NotesRecord();
    KeyWord = "Covariant Derivative";
    Rec.SeeAlso = "Directional Derivative";
    Rec.MainText = "The derivative along the tangent to the surface...";
    SetRecord( KeyWord, Rec, false );


    // Directional Derivative

    // Jacobian

    }
*/


  }
}
