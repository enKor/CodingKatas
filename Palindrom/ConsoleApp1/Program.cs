using BenchmarkDotNet.Running;
using Lib;

var sum = BenchmarkRunner.Run<Palindrom>();
