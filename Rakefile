task :default => :build

task :build do
	sh "nuget restore Projects/GestureRecognizers.PCL/packages.config -PackagesDirectory Solutions/packages/"
	sh "nuget restore Projects/GestureRecognizers.Droid/packages.config -PackagesDirectory Solutions/packages/"
	sh "nuget restore Tests/GestureRecognizerTests/packages.config -PackagesDirectory Solutions/packages/"

	puts "Nugets Restored"

	sh "xbuild Projects/GestureRecognizers.PCL/GestureRecognizers.PCL.csproj"
	puts "Built PCL Library"
	puts
	sh "xbuild Projects/GestureRecognizers.Droid/GestureRecognizers.Droid.csproj"
	puts "Build Droid Project"
	puts
end