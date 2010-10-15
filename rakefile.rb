require 'rake'
require 'albacore'

DOT_NET_PATH = "#{ENV["SystemRoot"]}\\Microsoft.NET\\Framework\\v4.0.30319"

ENV["config"] = "Debug" if ENV["config"].nil?
CONFIG = ENV["config"]

task :default => [:compile, :test]

desc "Compile solution"
msbuild :compile do |msb|
    msb.properties :configuration => CONFIG
    msb.path_to_command = File.join(DOT_NET_PATH, "msbuild.exe")
    msb.targets :Clean, :Build
    msb.solution = "Joey.sln"
end

xunit :test => [:compile] do |xunit|
    xunit.path_to_command = "lib/xunit.console.clr4.exe"
    xunit.assembly = "tst/Joey.Tests/bin/#{CONFIG}/Joey.Tests.dll"
end
