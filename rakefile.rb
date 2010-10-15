require 'rake'
require 'albacore'

task :default => [:compile]

desc "Compile solution"
msbuild :compile do |msb|
    msb.properties :configuration => :Debug
    msb.targets :Clean, :Build
    msb.solution = "Joey.sln"
end

