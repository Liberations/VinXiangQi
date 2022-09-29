﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinXiangQi
{
    public class ProgramSettings
    {
        public Dictionary<string, EngineSettings> EngineList = new Dictionary<string, EngineSettings>();
        public string SelectedEngine = "";
        public float ScaleFactor = 1.0f;
        public bool AutoGo = true;
        public double EngineStepTime = 2.0;
        public int StopScore = 2000;
        public int EngineDepth = 200;
        public int ThreadCount = 4;
        public int DetectionConfirmCount = 1;
        public int DetectionInterval = 550;
        public bool KeepDetecting = false;
        public bool UniversalMode = false;
        public bool UniversalMouse = false;
        public string SelectedSolution = "天天象棋";
        public bool AnalyzingMode = false;
        public bool AutoClick = false;
        public bool StopWhenMate = false;
        public string YoloModel = "nano.onnx";
        public bool UseOpenBook = false;
        public bool UseChessDB = false;
        public bool BackgroundAnalysis = false;
        public double MinTimeUsingOpenbook = 1.0;
        public OpenBookMode OpenbookMode = OpenBookMode.HighestScore;
       
        public enum OpenBookMode
        {
            HighestScore,
            Random
        }

        public EngineSettings CurrentEngine
        {
            get
            {
                if (EngineList.ContainsKey(SelectedEngine))
                {
                    return EngineList[SelectedEngine];
                }
                return null;
            }
        }
    }

    public class EngineSettings
    {
        public string ExePath = "";
        public string Name = "";
        public string Author = "";
        public Dictionary<string, string> Configs = new Dictionary<string, string>();
    }
}
