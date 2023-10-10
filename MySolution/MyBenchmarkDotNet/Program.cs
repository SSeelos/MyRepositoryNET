using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;
using MyBenchmarkDotNet;

Summary results = BenchmarkRunner.Run<MyBenchmarkClass>();
