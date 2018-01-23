using System;
using ObjCRuntime;

[assembly: LinkWith("libWeChatSDK.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Arm64 | LinkTarget.ArmV6 | LinkTarget.Simulator, SmartLink = true, ForceLoad = true,
                     Frameworks = "SystemConfiguration Security CoreTelephony CFNetwork",
                     LinkerFlags = "-lz -lsqlite3.0 -lc++ -Objc -all_load")]
