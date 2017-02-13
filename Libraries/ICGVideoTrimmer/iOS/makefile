POD=ICGVideoTrimmer
OS=ios
SDK=iphoneos
CONFIGURATION=Release
BINDINGPROJECTFOLDER=../Binding
WorkingDirectry=Native

all : clean create download generate copy

create : 
	mkdir $(WorkingDirectry)
		
download :
		cp Podfile $(WorkingDirectry) && cd $(WorkingDirectry) && pod install

generate : 
		cd $(WorkingDirectry) && sharpie pod bind -n 'ICGVideoTrimmerBinding'

copy : 
	cd $(WorkingDirectry) && cp ./Binding/$(POD)_ApiDefinitions.cs ../Binding/ApiDefinitions.cs
	cd $(WorkingDirectry) && cp -r ./Binding/$(POD).framework ../Binding


clean :
	rm -rf ./$(BINDINGPROJECTFOLDER)/*.cs
	rm -rf $(WorkingDirectry)
	