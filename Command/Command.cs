﻿namespace CMPS253.GoFPatterns.Command
{
    public abstract class Command
    {
        public abstract void Execute();
        public abstract void UnExecute();
    }
}