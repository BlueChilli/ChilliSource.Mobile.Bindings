POD=SSAccessibility
PROJECTNAME=Accessibility

OS=ios
SDK=iphoneos
CONFIGURATION=Release
BINDINGPROJECTFOLDER=../Binding
WorkingDirectry=Native

all : clean create download generate copy

create : 
	mkdir $(WorkingDirectry)

download :
		cd $(WorkingDirectry) && sharpie pod init $(OS) $(POD) --force

generate : 
		cd $(WorkingDirectry) && sharpie pod bind -n $(PROJECTNAME)
		

copy : 
	cd $(WorkingDirectry) && cp ./Binding/$(POD)_ApiDefinitions.cs ./Binding/ApiDefinitions.cs
	cd $(WorkingDirectry) && cp -r ./Binding/$(POD).framework ../Binding
	cd $(WorkingDirectry) && cp -r ./Pods/$(POD)/$(POD).bundle ../Binding/Resources

clean :
	rm -rf ./$(BINDINGPROJECTFOLDER)/*.cs
	rm -rf $(WorkingDirectry)