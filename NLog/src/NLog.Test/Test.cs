// 
// Copyright (c) 2004 Jaroslaw Kowalski <jaak@polbox.com>
// 
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without 
// modification, are permitted provided that the following conditions 
// are met:
// 
// * Redistributions of source code must retain the above copyright notice, 
//   this list of conditions and the following disclaimer. 
// 
// * Redistributions in binary form must reproduce the above copyright notice,
//   this list of conditions and the following disclaimer in the documentation
//   and/or other materials provided with the distribution. 
// 
// * Neither the name of the Jaroslaw Kowalski nor the names of its 
//   contributors may be used to endorse or promote products derived from this
//   software without specific prior written permission. 
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
// AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE 
// IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE 
// ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE 
// LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR 
// CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF
// SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS 
// INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN 
// CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
// ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF 
// THE POSSIBILITY OF SUCH DAMAGE.
// 

using System;
using System.IO;
using System.Security.Principal;
using System.Runtime.InteropServices;

using NLog;
using NLog.Config;

class Test {
    static void Main(string[] args) {
        NLog.Logger l = NLog.LogManager.GetLogger("Aaa");
        NLog.Logger l2 = NLog.LogManager.GetLogger("Bbb");

        l.Debug("to jest debug");
        l.Info("to jest info");
        l.Warn("to jest warning");
        l2.Debug("to jest debug");
        l2.Info("to jest info");
        l2.Warn("to jest warning");
        l.Error("to jest error");
        l.Fatal("to jest fatal");
        l2.Error("to jest error");
        l2.Fatal("to jest fatal");
        
        File.Copy("Config1.nlog", "NLog.Test.exe.config", true);
        System.Threading.Thread.Sleep(100);

        l.Debug("to jest debug");
        l.Info("to jest info");
        l.Warn("to jest warning");
        l2.Debug("to jest debug");
        l2.Info("to jest info");
        l2.Warn("to jest warning");
        l.Error("to jest error");
        l.Fatal("to jest fatal");
        l2.Error("to jest error");
        l2.Fatal("to jest fatal");
        File.Copy("Config2.nlog", "NLog.Test.exe.config", true);
        System.Threading.Thread.Sleep(100);
        l.Debug("to jest debug");
        l.Info("to jest info");
        l.Warn("to jest warning");
        l2.Debug("to jest debug");
        l2.Info("to jest info");
        l2.Warn("to jest warning");
        l.Error("to jest error");
        l.Fatal("to jest fatal");
        l2.Error("to jest error");
        l2.Fatal("to jest fatal");
    }
}