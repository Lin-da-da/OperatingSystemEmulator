using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kernel.Programs
{
    using System;

    public class Parser
    {
        private Parser()
        {
            // 私有构造函数，禁止直接实例化Parser类
        }

        public static Parser CreateParser()
        {
            return new Parser();
        }

        public void ExecuteScript(string script)
        {
            string[] lines = script.Split('\n');

            foreach (string line in lines)
            {
                string trimmedLine = line.Trim();

                if (string.IsNullOrWhiteSpace(trimmedLine) || trimmedLine.StartsWith("#"))
                {
                    continue; // 忽略空行和注释
                }

                try
                {
                    ParseStatement(trimmedLine);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"解析错误: {ex.Message}");
                }
            }
        }

        private void ParseStatement(string statement)
        {
            if (statement.StartsWith("/"))
            {
                ParseSystemCommand(statement);
            }
            else
            {
                ParseOperationStatement(statement);
            }
        }

        private void ParseSystemCommand(string statement)
        {
            string[] tokens = statement.Split(' ');

            string command = tokens[0];

            switch (command)
            {
                case "/time":
                    if (tokens.Length > 1)
                    {
                        string arg = tokens[1];
                        Console.WriteLine($"执行系统指令：{command} {arg}");
                        // 执行获取系统时间刻并储存至arg的逻辑
                    }
                    else
                    {
                        Console.WriteLine($"执行系统指令：{command}");
                        // 执行获取系统时间刻的逻辑
                    }
                    break;
                case "/in":
                    if (tokens.Length > 1)
                    {
                        string arg = tokens[1];
                        Console.WriteLine($"执行系统指令：{command} {arg}");
                        // 执行从标准输入读取数据并赋值给arg的逻辑
                    }
                    else
                    {
                        Console.WriteLine($"解析错误: {command} 缺少参数");
                    }
                    break;
                case "/out":
                    if (tokens.Length > 1)
                    {
                        string arg = tokens[1];
                        Console.WriteLine($"执行系统指令：{command} {arg}");
                        // 执行将arg的值输出到标准输出的逻辑
                    }
                    else
                    {
                        Console.WriteLine($"解析错误: {command} 缺少参数");
                    }
                    break;
                case "/access":
                    if (tokens.Length > 2)
                    {
                        string deviceName = tokens[1];
                        int value = int.Parse(tokens[2]);
                        Console.WriteLine($"执行系统指令：{command} {deviceName} {value}");
                        // 执行启用设备并指定使用时长的逻辑
                    }
                    else
                    {
                        Console.WriteLine($"解析错误: {command} 缺少参数");
                    }
                    break;
                case "/exit":
                    Console.WriteLine($"执行系统指令：{command}");
                    // 执行退出程序的逻辑
                    break;
                default:
                    Console.WriteLine("Unknowed System Command ERROR");
                    break;
            }
        }

        private void ParseOperationStatement(string statement)
        {
            string[] tokens = statement.Split('=');

            if (tokens.Length != 2)
            {
                Console.WriteLine("Invalid Scripts ERROR");
                return;
            }

            string leftOperand = tokens[0].Trim();
            string rightOperand = tokens[1].Trim();

            if (leftOperand.EndsWith("++") || leftOperand.EndsWith("--"))
            {
                string arg = leftOperand.Substring(0, leftOperand.Length - 2);
                string operatorSymbol = leftOperand.Substring(leftOperand.Length - 2);

                Console.WriteLine($"执行操作语句：{arg} {operatorSymbol}");
                // 执行自增或自减操作的逻辑
            }
            else
            {
                Console.WriteLine($"执行操作语句：{leftOperand} = {rightOperand}");
                // 执行赋值操作的逻辑
            }
        }
    }


}
