require 'rake'
require 'rake/clean'
require 'albacore'
require 'fileutils'

DOT_NET_PATH = "#{ENV["SystemRoot"]}\\Microsoft.NET\\Framework\\v4.0.30319"
OUTPUT_PATH = "out"

ENV["config"] = "Debug" if ENV["config"].nil?
CONFIG = ENV["config"]

CLEAN.include(OUTPUT_PATH)

desc "Full compile and test"
task :default => [:clean, :compile, :test, :copy_to_output]

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

task :copy_to_output => [:compile] do
    build_artefacts = FileList.new("src/**/#{CONFIG}/.").exclude("/obj/")
    FileUtils.cp_r build_artefacts, "#{OUTPUT_PATH}/#{CONFIG}/"
end
