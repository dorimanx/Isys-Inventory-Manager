
// Isy's Inventory Manager
// ===================
// Version: 2.6.4
// Date: 2019-06-23

//  =======================================================================================
//                                                                            --- Configuration ---
//  =======================================================================================

// --- Sorting ---
// =======================================================================================

// Define the keyword a cargo container has to contain in order to be recognized as a container of the given type.
const string oreContainerKeyword = "Ores";
const string ingotContainerKeyword = "Ingots";
const string componentContainerKeyword = "Components";
const string toolContainerKeyword = "Tools";
const string ammoContainerKeyword = "Ammo";
const string bottleContainerKeyword = "Bottles";

// Keyword an inventory has to contain to be skipped by the sorting (= no items will be taken out)
const string lockedContainerKeyword = "Locked";

// Keyword an inventory has to contain to be excluded from item counting (used by autocrafting and inventory panels)
const string hiddenContainerKeyword = "Hidden";

// Keyword for connectors to disable sorting of a grid, that is docked to that connector.
// This also disables the usage of refineries, arc furnaces and assemblers on that grid.
// Special containers, reactors and O2/H2 generators will still be filled.
string noSortingKeyword = "[No Sorting]";

// Balance items between containers of the same type? This will result in an equal amount of all items in all containers of that type.
bool balanceTypeContainers = false;

// Show a fill level in the container's name?
bool showFillLevel = true;

// Tag inventories, that have no access to the main type containers with [No Conveyor]?
bool showNoConveyorTag = true;

// Auto assign new containers if a type is full or not present?
bool autoAssignContainers = true;

// Auto assign ores and ingots containers as one?
bool oresIngotsInOne = true;

// Auto assign tool, ammo and bottle containers as one?
bool toolsAmmoBottlesInOne = true;

// Fill bottles before storing them in the bottle container?
bool fillBottles = true;


// --- Autocrafting ---
// =======================================================================================

// Enable autocrafting or autodisassembling (disassembling will disassemble everything above the wanted amounts)
// All assemblers will be used. To use one manually, add the manualMachineKeyword to it (by default: "!manual")
bool enableAutocrafting = true;
bool enableAutodisassembling = false;

// A LCD with the keyword "Autocrafting" is required where you can set the wanted amount!
// This has multi LCD support. Just append numbers after the keyword, like: "LCD Autocrafting 1", "LCD Autocrafting 2", ..
string autocraftingKeyword = "Autocrafting";

// If you want an assembler to only assemble or only disassemble, use the following keywords in its name.
// A assembler without a keyword will do both tasks
string assembleKeyword = "!assemble-only";
string disassembleKeyword = "!disassemble-only";

// You can teach the script new crafting recipes, by adding one of the following tags to an assembler's name.
// This is needed if the autocrafting screen shows [NoBP] for an item. There are two tag options to teach new blueprints:
// !learn will learn one item and then remove the tag so that the assembler is part of the autocrafting again.
// !learnMany will learn everything you queue in it and will never be part of the autorafting again until you remove the tag.
// To learn an item, queue it up about 100 times (Shift+Klick) and wait until the script removes it from the queue.
string learnKeyword = "!learn";
string learnManyKeyword = "!learnMany";

// Margins for assembling or disassembling items in percent based on the wanted amount (default: 0 = exact value).
// Examples:
// assembleMargin = 5 with a wanted amount of 100 items will only produce new items, if less than 95 are available.
// disassembleMargin = 10 with a wanted amount of 1000 items will only disassemble items if more than 1100 are available.
double assembleMargin = 0;
double disassembleMargin = 0;

// Add the header to every screen when using multiple autocrafting LCDs?
bool headerOnEveryScreen = false;

// To hide certain items from the LCD, simply set their wanted amount to a negative value (e.g.: -1 or -500). These items will be moved
// to the custom data of the first autocrafting LCD. To let them reappear on the LCD again, remove the entry from the custom data.

// Sort the assembler queue based on the most needed components?
bool sortAssemblerQueue = true;

// Autocraft ingots from stone in survival kits until you have proper refineries?
bool enableBasicIngotCrafting = true;

// Disable autocrafting in survival kits when you have regular assemblers?
bool disableBasicAutocrafting = true;


// --- Special Loadout Containers ---
// =======================================================================================

// Keyword an inventory has to contain to be filled with a special loadout (see in it's custom data after you renamed it!)
// Special containers will be filled with your wanted amount of items and never be drained by the auto sorting!
const string specialContainerKeyword = "Special";

// Are special containers allowed to 'steal' items from other special containers with a lower priority?
bool allowSpecialSteal = true;


// --- Refinery handling ---
// =======================================================================================

// By enabling ore balancing, the script will balance the ores between all refinieres so that every refinery has the same amount of ore in it.
// To still use a refinery manually, add the manualMachineKeyword to it (by default: "!manual")
bool enableOreBalancing = true;

// Enable script assisted refinery filling? This will move in the most needed ore and will make room, if the refinery is already full
// Also, the script puts as many ores into the refinery as possible and will pull ores even from other refineries if needed.
bool enableScriptRefineryFilling = true;

// Sort the refinery queue based on the most needed ingots?
bool sortRefiningQueue = true;

// If you want an ore to always be refined first, simple remove the two // in front of the ore name to enable it.
// Enabled ores are refined in order from top to bottom so if you removed several // you can change the order by
// copying and pasting them inside the list. Just be careful to keep the syntax correct: "OreName",
// By default stone is enabled and will always be refined first.
List<String> fixedRefiningList = new List<string> {
	"Stone",
	//"Iron",
	//"Nickel",
	//"Cobalt",
	//"Silicon",
	//"Uranium",
	//"Silver",
	//"Gold",
	//"Platinum",
	//"Magnesium",
	//"Scrap",
};


// --- O2/H2 generator handling ---
// =======================================================================================

// Enable balancing of ice in O2/H2 generators?
// All O2/H2 generators will be used. To use one manually, add the manualMachineKeyword to it (by default: "!manual")
bool enableIceBalancing = true;

// Put ice into O2/H2 generators that are turned off? (default: false)
bool fillOfflineGenerators = false;

// Ice fill level in percent in order to be able to fill bottles? (default: 90)
// Note: O2/H2 generators will pull more ice automatically if value is below 60%
double iceFillLevelPercentage = 90;


// --- Reactor handling ---
// =======================================================================================

// Enable balancing of uranium in reactors? (Note: conveyors of reactors are turned off to stop them from pulling more)
// All reactors will be used. To use one manually, add the manualMachineKeyword to it (by default: "!manual")
bool enableUraniumBalancing = true;

// Put uranium into reactors that are turned off? (default: false)
bool fillOfflineReactors = false;

// Amount of uranium in each reactor? (default: 100 for large grid reactors, 25 for small grid reactors)
double uraniumAmountLargeGrid = 100;
double uraniumAmountSmallGrid = 25;


// --- Assembler Cleanup ---
// =======================================================================================

// This cleans up assemblers, if they have no queue and puts the contents back into a cargo container.
bool enableAssemblerCleanup = true;


// --- Internal item sorting ---
// =======================================================================================

// Sort the items inside all containers?
// Note, that this could cause inventory desync issues in multiplayer, so that items are invisible
// or can't be taken out. Use at your own risk!
bool enableInternalSorting = false;

// Internal sorting pattern. Always combine one of each category, e.g.: 'Ad' for descending item amount (from highest to lowest)
// 1. Quantifier:
// A = amount
// N = name
// T = type (alphabetical)
// X = type (number of items)

// 2. Direction:
// a = ascending
// d = descending

string sortingPattern = "Na";

// Internal sorting can also be set per inventory. Just use '(sort:PATTERN)' in the block's name.
// Example: Small Cargo Container 3 (sort:Ad)
// Note: Using this method, internal sorting will always be activated for this container, even if the main switch is turned off!


// --- LCD panels ---
// =======================================================================================

// To display the main script informations, add the following keyword to any LCD name (default: !IIM-main).
// You can enable or disable specific informations on the LCD by editing its custom data.
string mainLCDKeyword = "!IIM-main";

// To display current item amounts of different types, add the following keyword to any LCD name
// and follow the on screen instructions.
string inventoryLCDKeyword = "!IIM-inventory";

// To display all current warnings and problems, add the following keyword to any LCD name (default: IIM-warnings).
string warningsLCDKeyword = "!IIM-warnings";

// To display the script performance (PB terminal output), add the following keyword to any LCD name (default: !IIM-performance).
string performanceLCDKeyword = "!IIM-performance";

// Default screen font and fontsize, when a screen is first initialized. Fonts: "Debug" or "Monospace"
string defaultFont = "Debug";
float defaultFontSize = 0.6f;


// --- Settings for enthusiasts ---
// =======================================================================================

// Script cycle time in seconds (default: 9).
double scriptExecutionTime = 9;

// Script mode: "ship", "station" or blank for autodetect
string scriptMode = "";

// Protect type containers when docking to another grid running the script?
bool protectTypeContainers = true;

// If you want to use a machine manually, append the keyword to it.
// This works for assemblers, refineries, reactors and O2/H2 generators
string manualMachineKeyword = "!manual";


//  =======================================================================================
//                                                                      --- End of Configuration ---
//                                                        Don't change anything beyond this point!
//  =======================================================================================


List<IMyTerminalBlock>Ȳ=new List<IMyTerminalBlock>();List<IMyTerminalBlock>ȳ=new List<IMyTerminalBlock>();List<
IMyTerminalBlock>ȴ=new List<IMyTerminalBlock>();List<IMyTerminalBlock>ȵ=new List<IMyTerminalBlock>();List<IMyTerminalBlock>ȶ=new List<
IMyTerminalBlock>();List<IMyTerminalBlock>ȷ=new List<IMyTerminalBlock>();List<IMyTerminalBlock>ȸ=new List<IMyTerminalBlock>();List<
IMyShipConnector>ȹ=new List<IMyShipConnector>();List<IMyRefinery>Ⱥ=new List<IMyRefinery>();List<IMyRefinery>ȱ=new List<IMyRefinery>();
List<IMyRefinery>ȼ=new List<IMyRefinery>();List<IMyRefinery>Ƚ=new List<IMyRefinery>();List<IMyAssembler>ɝ=new List<
IMyAssembler>();List<IMyAssembler>ɞ=new List<IMyAssembler>();List<IMyAssembler>ɟ=new List<IMyAssembler>();List<IMyAssembler>ɠ=new
List<IMyAssembler>();List<IMyGasGenerator>ɡ=new List<IMyGasGenerator>();List<IMyReactor>ɢ=new List<IMyReactor>();List<
IMyTextPanel>ɣ=new List<IMyTextPanel>();List<string>ɤ=new List<string>();HashSet<IMyCubeGrid>ɥ=new HashSet<IMyCubeGrid>();List<
IMyTerminalBlock>ɦ=new List<IMyTerminalBlock>();List<IMyTerminalBlock>ɧ=new List<IMyTerminalBlock>();List<IMyTerminalBlock>ɨ=new List<
IMyTerminalBlock>();List<IMyTerminalBlock>ɩ=new List<IMyTerminalBlock>();List<IMyTerminalBlock>ɪ=new List<IMyTerminalBlock>();List<
IMyTerminalBlock>ɫ=new List<IMyTerminalBlock>();List<IMyTerminalBlock>ɭ=new List<IMyTerminalBlock>();string[]ɼ={oreContainerKeyword,
ingotContainerKeyword,componentContainerKeyword,toolContainerKeyword,ammoContainerKeyword,bottleContainerKeyword};string ɮ="";
IMyTerminalBlock ɯ;IMyInventory ɰ;IMyTerminalBlock ɱ;int ɲ=0;int ɳ=0;int ɴ=0;int ɵ=0;int ɶ=0;int ɷ=0;int ɸ=0;int ɹ=0;int ɺ=0;int ɻ=0;int
ɽ=0;int ɬ=0;string ɜ="";string[]Ɋ={"/","-","\\","|"};int Ⱦ=0;List<IMyTerminalBlock>ȿ=new List<IMyTerminalBlock>();List<
IMyTerminalBlock>ɀ=new List<IMyTerminalBlock>();List<IMyTerminalBlock>Ɂ=new List<IMyTerminalBlock>();List<IMyTerminalBlock>ɂ=new List<
IMyTerminalBlock>();string[]ƽ={"showHeading=true","showWarnings=true","showContainerStats=true","showManagedBlocks=true",
"showLastAction=true","scrollTextIfNeeded=true"};string[]Ƀ={"showHeading=true","scrollTextIfNeeded=true"};string Ĳ;int Ʉ=0;string Ʌ="";bool Ɇ
=false;bool ɇ=false;HashSet<string>Ɉ=new HashSet<string>();HashSet<string>ɉ=new HashSet<string>();int ɋ=0;int ɚ=0;int Ɍ=0
;bool ɍ=true;bool Ɏ=false;int ɏ=0;string ɐ="itemID;blueprintID";Dictionary<string,string>ɑ=new Dictionary<string,string>(
){{"oreContainer",oreContainerKeyword},{"ingotContainer",ingotContainerKeyword},{"componentContainer",
componentContainerKeyword},{"toolContainer",toolContainerKeyword},{"ammoContainer",ammoContainerKeyword},{"bottleContainer",
bottleContainerKeyword},{"lockedContainer",lockedContainerKeyword},{"specialContainer",specialContainerKeyword},{"oreBalancing","true"},{
"iceBalancing","true"},{"uraniumBalancing","true"}};string ɒ="Isy's Autocrafting";string ɓ=
"Remove a line to show this item on the LCD again!";char[]ɔ={'=','>','<'};IMyAssembler ɕ;string ɖ="";MyDefinitionId ɗ;List<String>ɘ=new List<string>{"Uranium","Silicon",
"Silver","Gold","Platinum","Magnesium","Iron","Nickel","Cobalt","Stone","Scrap"};List<MyItemType>ə=new List<MyItemType>();List<
MyItemType>ɛ=new List<MyItemType>();Dictionary<string,double>Ȱ=new Dictionary<string,double>(){{"Cobalt",0.3},{"Gold",0.01},{
"Iron",0.7},{"Magnesium",0.007},{"Nickel",0.4},{"Platinum",0.005},{"Silicon",0.7},{"Silver",0.1},{"Stone",0.014},{"Uranium",
0.01}};const string ǥ="MyObjectBuilder_";const string ȇ="Ore";const string Ǧ="Ingot";const string ǧ="Component";const string
Ǩ="AmmoMagazine";const string ǩ="OxygenContainerObject";const string Ǫ="GasContainerObject";const string ǫ=
"PhysicalGunObject";const string Ǭ=ǥ+"BlueprintDefinition/";SortedSet<MyDefinitionId>ǭ=new SortedSet<MyDefinitionId>(new Œ());SortedSet<
string>Ǯ=new SortedSet<string>();SortedSet<string>ǯ=new SortedSet<string>();SortedSet<string>ǰ=new SortedSet<string>();
SortedSet<string>Ǳ=new SortedSet<string>();SortedSet<string>ǲ=new SortedSet<string>();SortedSet<string>ǳ=new SortedSet<string>();
SortedSet<string>ǵ=new SortedSet<string>();Dictionary<MyDefinitionId,double>Ȅ=new Dictionary<MyDefinitionId,double>();Dictionary<
MyDefinitionId,double>Ƕ=new Dictionary<MyDefinitionId,double>();Dictionary<MyDefinitionId,double>Ƿ=new Dictionary<MyDefinitionId,
double>();Dictionary<MyDefinitionId,MyDefinitionId>Ǹ=new Dictionary<MyDefinitionId,MyDefinitionId>();Dictionary<MyDefinitionId
,MyDefinitionId>ǹ=new Dictionary<MyDefinitionId,MyDefinitionId>();Dictionary<string,MyDefinitionId>Ǻ=new Dictionary<
string,MyDefinitionId>();Dictionary<string,string>ǻ=new Dictionary<string,string>();bool Ǽ=false;string ǽ="station_mode;\n";
string Ǿ="ship_mode;\n";string ǿ="[PROTECTED] ";string Ȁ="";string ȁ="";string Ȃ="";DateTime ȃ;string[]ȅ={
"Get inventory blocks","Find new items","Create item lists","Name correction","Assign containers","Fill special containers","Sort items",
"Container balancing","Internal sorting","Add fill level to names","Get global item amount","Get assembler queue","Autocrafting",
"Sort assembler queue","Clean up assemblers","Learn unknown blueprints","Fill refineries","Ore balancing","Ice balancing","Uranium balancing"}
;Program(){Echo("Script ready to be launched..\n");assembleMargin/=100;disassembleMargin/=100;ɋ=(int)Math.Floor(
scriptExecutionTime/9.5);Runtime.UpdateFrequency=UpdateFrequency.Update10;}void Main(string Ǔ){if(Ʉ>=10){throw new Exception(
"Too many errors in script step "+Ɍ+":\n"+ȅ[Ɍ]+"\n\nPlease recompile!\nScript stoppped!\n\nLast error:\n"+Ʌ+"\n");}try{Ƶ("",true);if(ɍ){Runtime.
UpdateFrequency=UpdateFrequency.Update100;if(Ɍ>0)Echo("Initializing script.. ("+(Ɍ+1)+"/10) \n");if(Ɍ>=2){Echo(
"Getting inventory blocks..");if(Ɍ==2)ș();}if(Ɍ>=3){Echo("Loading saved items..");if(Ɍ==3){if(!Ø()){Echo("-> No assembler found!");Echo(
"-> Can't check saved blueprints..");Echo("\nScript stopped!");Me.Enabled=false;return;}}}if(Ɍ>=4){Echo("Clearing assembler queues..");if(Ɍ==4&&(
enableAutocrafting||enableAutodisassembling)){GridTerminalSystem.GetBlocksOfType<IMyTextPanel>(ɣ,e=>e.IsSameConstructAs(Me)&&e.CustomName.
Contains(autocraftingKeyword));if(ɣ.Count>0){foreach(var Ā in ɝ){Ā.Mode=MyAssemblerMode.Disassembly;Ā.ClearQueue();Ā.Mode=
MyAssemblerMode.Assembly;Ā.ClearQueue();}}}}if(Ɍ>=5){Echo("Checking blueprints..");if(Ɍ==5){foreach(var H in ǭ){Ɩ(H);}}}if(Ɍ>=6){Echo(
"Checking type containers..");if(Ɍ==6)ȡ();}if(Ɍ>=7){if(scriptMode=="station"){Ǽ=true;}else if(Me.CubeGrid.IsStatic&&scriptMode!="ship"){Ǽ=true;}Echo
("Setting script mode to: "+(Ǽ?"station..":"ship.."));if(Ɍ==7)Me.CustomData=(Ǽ?ǽ:Ǿ)+Me.CustomData.Replace(ǽ,"").Replace(Ǿ
,"");}if(Ɍ>=8){Echo("Starting script..");}if(Ɍ>=9){Runtime.UpdateFrequency=UpdateFrequency.Update10;Ɍ=0;ɍ=false;return;}Ɍ
++;return;}if(Ǔ!=""){Ȃ=Ǔ;Ɍ=1;ȁ="";ȃ=DateTime.Now;}if(ɚ<ɋ){ɚ++;return;}if(Ɏ){if(ɏ==0)ú();if(ɏ==1)į();if(ɏ==2)ĳ();if(ɏ==3)ĵ(
);if(ɏ>3)ɏ=0;Ɏ=false;return;}if(Ɍ==0||Ɇ){if(!ɇ)ș();Ɇ=false;ɇ=false;if(!ƻ(30)){ȿ=Ƽ(mainLCDKeyword,ƽ);ɀ=Ƽ(
warningsLCDKeyword,Ƀ);Ɂ=Ƽ(performanceLCDKeyword,Ƀ);ɂ=Ƽ(inventoryLCDKeyword);}else{Ɇ=true;ɇ=true;}if(Ɍ==0){Ƶ(ȅ[Ɍ]);z();Ɍ++;}return;}if(!Ǽ)Ǚ
();if(ǒ(Ȃ))return;ɚ=0;Ɏ=true;if(Ɍ==1){Í();}if(Ɍ==2){ê();}if(Ɍ==3){Ƞ();}if(Ɍ==4){if(autoAssignContainers)Ȫ();}if(Ɍ==5){if(
ɭ.Count!=0)ˈ();}if(Ɍ==6){Ȋ();}if(Ɍ==7){if(balanceTypeContainers)ͻ();}if(Ɍ==8){ˊ();}if(Ɍ==9){ʽ(ȶ);ʽ(ɭ);}if(Ɍ==10){Ơ();}if(
Ɍ==11){if(enableAutocrafting||enableAutodisassembling)Ǝ();}if(Ɍ==12){if(enableAutocrafting||enableAutodisassembling)Β();}
if(Ɍ==13){if(sortAssemblerQueue)ʝ();}if(Ɍ==14){if(enableAssemblerCleanup)ʌ();if(enableBasicIngotCrafting){if(Ⱥ.Count>0){
enableBasicIngotCrafting=false;}else{Ή();}}}if(Ɍ==15){Õ();}if(Ɍ==16){ʓ();}if(Ɍ==17){if(enableOreBalancing)ʕ();if(sortRefiningQueue){ʖ(ȼ,ə);ʖ(Ƚ,ɛ
);}}if(Ɍ==18){if(enableIceBalancing)ʬ();}if(Ɍ==19){if(enableUraniumBalancing){á("uraniumBalancing","true");Č();}else if(!
enableUraniumBalancing&&Þ("uraniumBalancing")=="true"){á("uraniumBalancing","false");foreach(IMyReactor đ in ɢ){đ.UseConveyorSystem=true;}}}Ƶ(
ȅ[Ɍ]);z();if(Ɍ>=19){Ɍ=0;Ɉ=new HashSet<string>(ɉ);ɉ.Clear();if(Ʉ>0)Ʉ--;if(Ɉ.Count==0)Ĳ=null;}else{Ɍ++;}Ⱦ=Ⱦ>=3?0:Ⱦ+1;}catch
(NullReferenceException e){Ʉ++;Ɇ=true;Ʌ=e.ToString();ƞ("Execution of script step aborted:\n"+ȅ[Ɍ]+" (ID: "+Ɍ+
")\n\nCached block not available..");}catch(Exception e){Ʉ++;Ɇ=true;Ʌ=e.ToString();ƞ("Critical error in script step:\n"+ȅ[Ɍ]+" (ID: "+Ɍ+")\n\n"+e);}}bool ǒ
(string Ǔ){if(Ǔ.Contains("pauseThisPB")){Echo("Script execution paused!\n");var ǔ=Ǔ.Split(';');if(ǔ.Length==3){Echo(
"Found:");Echo("'"+ǔ[1]+"'");Echo("on grid:");Echo("'"+ǔ[2]+"'");Echo("also running the script.\n");Echo(
"Type container protection: "+(protectTypeContainers?"ON":"OFF")+"\n");Echo("Everything else is managed by the other script.");}return true;}bool Ǖ=
true;bool ǖ=true;bool Ǘ=false;if(Ǔ!="reset"&&Ǔ!="msg"){if(!Ǔ.Contains(" on")&&!Ǔ.Contains(" off")&&!Ǔ.Contains(" toggle"))
return false;if(Ǔ.Contains(" off"))ǖ=false;if(Ǔ.Contains(" toggle"))Ǘ=true;}if(Ǔ=="reset"){Ɵ();return true;}else if(Ǔ=="msg"){
}else if(Ǔ.StartsWith("balanceTypeContainers")){Ȁ="Balance type containers";if(Ǘ)ǖ=!balanceTypeContainers;
balanceTypeContainers=ǖ;}else if(Ǔ.StartsWith("showFillLevel")){Ȁ="Show fill level";if(Ǘ)ǖ=!showFillLevel;showFillLevel=ǖ;}else if(Ǔ.
StartsWith("showNoConveyorTag")){Ȁ="Show no conveyor access";if(Ǘ)ǖ=!showNoConveyorTag;showNoConveyorTag=ǖ;}else if(Ǔ.StartsWith(
"autoAssignContainers")){Ȁ="Auto assing containers";if(Ǘ)ǖ=!autoAssignContainers;autoAssignContainers=ǖ;}else if(Ǔ.StartsWith(
"oresIngotsInOne")){Ȁ="Assign ores and ingots as one";if(Ǘ)ǖ=!oresIngotsInOne;oresIngotsInOne=ǖ;}else if(Ǔ.StartsWith(
"toolsAmmoBottlesInOne")){Ȁ="Assign tools, ammo and bottles as one";if(Ǘ)ǖ=!toolsAmmoBottlesInOne;toolsAmmoBottlesInOne=ǖ;}else if(Ǔ.StartsWith
("fillBottles")){Ȁ="Fill bottles";if(Ǘ)ǖ=!fillBottles;fillBottles=ǖ;}else if(Ǔ.StartsWith("enableAutocrafting")){Ȁ=
"Autocrafting";if(Ǘ)ǖ=!enableAutocrafting;enableAutocrafting=ǖ;}else if(Ǔ.StartsWith("enableAutodisassembling")){Ȁ="Autodisassembling"
;if(Ǘ)ǖ=!enableAutodisassembling;enableAutodisassembling=ǖ;}else if(Ǔ.StartsWith("headerOnEveryScreen")){Ȁ=
"Show header on every autocrafting screen";if(Ǘ)ǖ=!headerOnEveryScreen;headerOnEveryScreen=ǖ;}else if(Ǔ.StartsWith("sortAssemblerQueue")){Ȁ="Sort assembler queue"
;if(Ǘ)ǖ=!sortAssemblerQueue;sortAssemblerQueue=ǖ;}else if(Ǔ.StartsWith("enableBasicIngotCrafting")){Ȁ=
"Basic ingot crafting";if(Ǘ)ǖ=!enableBasicIngotCrafting;enableBasicIngotCrafting=ǖ;}else if(Ǔ.StartsWith("disableBasicAutocrafting")){Ȁ=
"Disable autocrafting in survival kits";if(Ǘ)ǖ=!disableBasicAutocrafting;disableBasicAutocrafting=ǖ;}else if(Ǔ.StartsWith("allowSpecialSteal")){Ȁ=
"Allow special container steal";if(Ǘ)ǖ=!allowSpecialSteal;allowSpecialSteal=ǖ;}else if(Ǔ.StartsWith("enableOreBalancing")){Ȁ="Ore balancing";if(Ǘ)ǖ=!
enableOreBalancing;enableOreBalancing=ǖ;}else if(Ǔ.StartsWith("enableScriptRefineryFilling")){Ȁ="Script assisted refinery filling";if(Ǘ)ǖ=
!enableScriptRefineryFilling;enableScriptRefineryFilling=ǖ;}else if(Ǔ.StartsWith("sortRefiningQueue")){Ȁ=
"Sort refinery queue";if(Ǘ)ǖ=!sortRefiningQueue;sortRefiningQueue=ǖ;}else if(Ǔ.StartsWith("enableIceBalancing")){Ȁ="Ice balancing";if(Ǘ)ǖ=!
enableIceBalancing;enableIceBalancing=ǖ;}else if(Ǔ.StartsWith("fillOfflineGenerators")){Ȁ="Fill offline O2/H2 generators";if(Ǘ)ǖ=!
fillOfflineGenerators;fillOfflineGenerators=ǖ;}else if(Ǔ.StartsWith("enableUraniumBalancing")){Ȁ="Uranium balancing";if(Ǘ)ǖ=!
enableUraniumBalancing;enableUraniumBalancing=ǖ;}else if(Ǔ.StartsWith("fillOfflineReactors")){Ȁ="Fill offline reactors";if(Ǘ)ǖ=!
fillOfflineReactors;fillOfflineReactors=ǖ;}else if(Ǔ.StartsWith("enableAssemblerCleanup")){Ȁ="Assembler cleanup";if(Ǘ)ǖ=!
enableAssemblerCleanup;enableAssemblerCleanup=ǖ;}else if(Ǔ.StartsWith("enableInternalSorting")){Ȁ="Internal sorting";if(Ǘ)ǖ=!
enableInternalSorting;enableInternalSorting=ǖ;}else if(Ǔ.StartsWith("protectTypeContainers")){Ȁ="Protect type containers";if(Ǘ)ǖ=!
protectTypeContainers;protectTypeContainers=ǖ;}else{Ǖ=false;}if(Ǖ){TimeSpan ǘ=DateTime.Now-ȃ;if(ȁ=="")ȁ=Ȁ+" temporarily "+(ǖ?"enabled":
"disabled")+"!\n";Echo(ȁ);Echo("Continuing in "+Math.Ceiling(3-ǘ.TotalSeconds)+" seconds..");Ȃ="msg";if(ǘ.TotalSeconds>=3){Ȁ="";ȁ=
"";Ȃ="";}}return Ǖ;}void Ǚ(){List<IMyProgrammableBlock>ǚ=new List<IMyProgrammableBlock>();GridTerminalSystem.
GetBlocksOfType(ǚ,Ǜ=>Ǜ!=Me);if(Ȃ.StartsWith("pauseThisPB")||Ȃ==""){Ȃ="";foreach(var ǜ in ǚ){if(ǜ.CustomData.Contains(ǽ)||(ǜ.CustomData.
Contains(Ǿ)&&V(ǜ)<V(Me))){Ȃ="pauseThisPB;"+ǜ.CustomName+";"+ǜ.CubeGrid.CustomName;foreach(var N in ȶ){if(protectTypeContainers&&
!N.CustomName.Contains(ǿ)&&N.IsSameConstructAs(Me))N.CustomName=ǿ+N.CustomName;}return;}}if(Ȃ==""){foreach(var N in ȷ){N.
CustomName=N.CustomName.Replace(ǿ,"");}}}}void ǝ(){ɥ.Clear();GridTerminalSystem.GetBlocksOfType<IMyShipConnector>(ȹ,ś=>ś.
IsSameConstructAs(Me)&&ś.CustomName.Contains(noSortingKeyword));if(ȹ.Count>0){foreach(var Ǟ in ȹ){if(Ǟ.Status!=MyShipConnectorStatus.
Connected)continue;ɥ.Add(Ǟ.OtherConnector.CubeGrid);}}}void ǟ(){if(ɰ!=null){try{ɰ=ɯ.GetInventory(0);}catch{ɰ=null;}}if(ɰ==null){
try{foreach(var N in ȶ){foreach(var I in Ȳ){if(N==I)continue;if(N.GetInventory(0).IsConnectedTo(I.GetInventory(0))){ɯ=ȶ[0];
ɰ=ɯ.GetInventory(0);return;}}}}catch{ɰ=null;}}}bool Ǡ(IMyTerminalBlock I){if(ƻ(30)){ƞ(
"Your grid is too big!\nNot all blocks could be indexed!");return false;}if(!I.HasInventory)return false;if(I.GetType().ToString().Contains("Weapon"))return false;foreach(var µ
in ɥ){if(I.CubeGrid.IsSameConstructAs(µ))return false;}string ǡ=I.CustomName;if(ǡ.Contains(ǿ)){ȷ.Add(I);return false;}bool
Ǣ=false,ǣ=ǡ.Contains(lockedContainerKeyword),Ǵ=ǡ.Contains(manualMachineKeyword),Ǥ=ǡ.Contains(hiddenContainerKeyword),Ȇ=ǡ.
Contains(learnKeyword)||ǡ.Contains(learnManyKeyword),ȗ=true,Ș=false;if(!Ǥ)Ȳ.Add(I);if(ɰ!=null){if(!I.GetInventory(0).
IsConnectedTo(ɰ)){ȗ=false;}}if(!ȗ){if(showNoConveyorTag)ȝ(I,"[No Conveyor]");return false;}else{ȝ(I,"[No Conveyor]",false);}if(ǡ.
Contains(oreContainerKeyword)){ɦ.Add(I);Ș=true;}if(ǡ.Contains(ingotContainerKeyword)){ɧ.Add(I);Ș=true;}if(ǡ.Contains(
componentContainerKeyword)){ɨ.Add(I);Ș=true;}if(ǡ.Contains(toolContainerKeyword)){ɩ.Add(I);Ș=true;}if(ǡ.Contains(ammoContainerKeyword)){ɪ.Add(I);
Ș=true;}if(ǡ.Contains(bottleContainerKeyword)){ɫ.Add(I);Ș=true;}if(ǡ.Contains(specialContainerKeyword)){ɭ.Add(I);if(I.
CustomData.Length<200)ä(I);Ǣ=true;}if(Ș)ȶ.Add(I);if(I is IMyRefinery){if(I.IsSameConstructAs(Me)&&!Ǣ&&!Ǵ&&I.IsWorking){(I as
IMyRefinery).UseConveyorSystem=true;Ⱥ.Add(I as IMyRefinery);if(I.BlockDefinition.SubtypeId=="Blast Furnace"){Ƚ.Add(I as IMyRefinery
);}else{ȼ.Add(I as IMyRefinery);}}if(!ǣ)ȱ.Add(I as IMyRefinery);}else if(I is IMyAssembler){if(I.IsSameConstructAs(Me)&&!
Ǵ&&!Ȇ&&I.IsWorking){ɝ.Add(I as IMyAssembler);if(I.BlockDefinition.SubtypeId.Contains("Survival"))ɠ.Add(I as IMyAssembler)
;}if(!ǣ&&!Ȇ)ɞ.Add(I as IMyAssembler);if(Ȇ)ɟ.Add(I as IMyAssembler);}else if(I is IMyGasGenerator){if(!Ǣ&&!Ǵ&&I.
IsFunctional){if(fillOfflineGenerators&&!(I as IMyGasGenerator).Enabled){ɡ.Add(I as IMyGasGenerator);}else if((I as IMyGasGenerator)
.Enabled){ɡ.Add(I as IMyGasGenerator);}}}else if(I is IMyReactor){if(!Ǣ&&!Ǵ&&I.IsFunctional){if(fillOfflineReactors&&!(I
as IMyReactor).Enabled){ɢ.Add(I as IMyReactor);}else if((I as IMyReactor).Enabled){ɢ.Add(I as IMyReactor);}}}else if(I is
IMyCargoContainer){if(I.IsSameConstructAs(Me)&&!Ș&&!ǣ&&!Ǣ)ȸ.Add(I);}if(I.InventoryCount==1&&!Ǣ&&!ǣ&&!(I is IMyReactor)){ȴ.Add(I);if(!I.
BlockDefinition.TypeIdString.Contains("Oxygen"))ȵ.Add(I);}return false;}void ș(){ǝ();ǟ();try{for(int X=0;X<ɭ.Count;X++){if(!ɭ[X].
CustomName.Contains(specialContainerKeyword))ɭ[X].CustomData="";}}catch{}ȶ.Clear();ɦ.Clear();ɧ.Clear();ɨ.Clear();ɩ.Clear();ɪ.Clear
();ɫ.Clear();ɭ.Clear();ȸ.Clear();ȷ.Clear();Ȳ.Clear();ȴ.Clear();ȵ.Clear();Ⱥ.Clear();ȼ.Clear();Ƚ.Clear();ȱ.Clear();ɝ.Clear(
);ɠ.Clear();ɞ.Clear();ɡ.Clear();ɢ.Clear();GridTerminalSystem.GetBlocksOfType<IMyTerminalBlock>(null,Ǡ);ț(ɦ);ț(ɧ);ț(ɨ);ț(ɩ
);ț(ɪ);ț(ɫ);ț(ɭ);ț(ȵ);if(disableBasicAutocrafting&&ɝ.Count!=ɠ.Count)ɝ.RemoveAll(ğ=>ğ.BlockDefinition.SubtypeId.Contains(
"Survival"));if(fillBottles){ȴ.Sort((Ț,ŏ)=>ŏ.BlockDefinition.TypeIdString.Contains("Oxygen").CompareTo(Ț.BlockDefinition.
TypeIdString.Contains("Oxygen")));}}void ț(List<IMyTerminalBlock>Ȝ){if(Ȝ.Count>=2)Ȝ.Sort((Ț,ŏ)=>V(Ț).CompareTo(V(ŏ)));}void ȝ(
IMyTerminalBlock I,string Ȟ,bool ȟ=true){if(ȟ){if(I.CustomName.Contains(Ȟ))return;I.CustomName+=" "+Ȟ;}else{if(!I.CustomName.Contains(Ȟ)
)return;I.CustomName=I.CustomName.Replace(" "+Ȟ,"").Replace(Ȟ,"").TrimEnd(' ');}}void ȡ(){bool Ȯ=false;string Ȣ=Þ(
"oreContainer");string ȣ=Þ("ingotContainer");string Ȥ=Þ("componentContainer");string ȥ=Þ("toolContainer");string Ȧ=Þ("ammoContainer");
string ȧ=Þ("bottleContainer");string Ȩ=Þ("lockedContainer");string ȩ=Þ("specialContainer");if(oreContainerKeyword!=Ȣ){Ȯ=true;}
else if(ingotContainerKeyword!=ȣ){Ȯ=true;}else if(componentContainerKeyword!=Ȥ){Ȯ=true;}else if(toolContainerKeyword!=ȥ){Ȯ=
true;}else if(ammoContainerKeyword!=Ȧ){Ȯ=true;}else if(bottleContainerKeyword!=ȧ){Ȯ=true;}else if(lockedContainerKeyword!=Ȩ)
{Ȯ=true;}else if(specialContainerKeyword!=ȩ){Ȯ=true;}if(Ȯ){for(int X=0;X<Ȳ.Count;X++){if(Ȳ[X].CustomName.Contains(Ȣ)){Ȳ[X
].CustomName=Ȳ[X].CustomName.Replace(Ȣ,oreContainerKeyword);}if(Ȳ[X].CustomName.Contains(ȣ)){Ȳ[X].CustomName=Ȳ[X].
CustomName.Replace(ȣ,ingotContainerKeyword);}if(Ȳ[X].CustomName.Contains(Ȥ)){Ȳ[X].CustomName=Ȳ[X].CustomName.Replace(Ȥ,
componentContainerKeyword);}if(Ȳ[X].CustomName.Contains(ȥ)){Ȳ[X].CustomName=Ȳ[X].CustomName.Replace(ȥ,toolContainerKeyword);}if(Ȳ[X].CustomName.
Contains(Ȧ)){Ȳ[X].CustomName=Ȳ[X].CustomName.Replace(Ȧ,ammoContainerKeyword);}if(Ȳ[X].CustomName.Contains(ȧ)){Ȳ[X].CustomName=Ȳ[
X].CustomName.Replace(ȧ,bottleContainerKeyword);}if(Ȳ[X].CustomName.Contains(Ȩ)){Ȳ[X].CustomName=Ȳ[X].CustomName.Replace(
Ȩ,lockedContainerKeyword);}if(Ȳ[X].CustomName.Contains(ȩ)){Ȳ[X].CustomName=Ȳ[X].CustomName.Replace(ȩ,
specialContainerKeyword);}}á("oreContainer",oreContainerKeyword);á("ingotContainer",ingotContainerKeyword);á("componentContainer",
componentContainerKeyword);á("toolContainer",toolContainerKeyword);á("ammoContainer",ammoContainerKeyword);á("bottleContainer",
bottleContainerKeyword);á("lockedContainer",lockedContainerKeyword);á("specialContainer",specialContainerKeyword);}}void Ȫ(){for(int X=0;X<ȸ.
Count;X++){bool ȫ=false;bool Ȭ=false;string ȭ=ȸ[X].CustomName;string ȯ="";if(ɦ.Count==0||ɮ=="Ore"){if(oresIngotsInOne){Ȭ=true
;}else{ȸ[X].CustomName+=" "+oreContainerKeyword;ɦ.Add(ȸ[X]);ȯ="Ores";}}else if(ɧ.Count==0||ɮ=="Ingot"){if(oresIngotsInOne
){Ȭ=true;}else{ȸ[X].CustomName+=" "+ingotContainerKeyword;ɧ.Add(ȸ[X]);ȯ="Ingots";}}else if(ɨ.Count==0||ɮ=="Component"){ȸ[
X].CustomName+=" "+componentContainerKeyword;ɨ.Add(ȸ[X]);ȯ="Components";}else if(ɩ.Count==0||ɮ=="PhysicalGunObject"){if(
toolsAmmoBottlesInOne){ȫ=true;}else{ȸ[X].CustomName+=" "+toolContainerKeyword;ɩ.Add(ȸ[X]);ȯ="Tools";}}else if(ɪ.Count==0||ɮ=="AmmoMagazine"){
if(toolsAmmoBottlesInOne){ȫ=true;}else{ȸ[X].CustomName+=" "+ammoContainerKeyword;ɪ.Add(ȸ[X]);ȯ="Ammo";}}else if(ɫ.Count==0
||ɮ=="OxygenContainerObject"||ɮ=="GasContainerObject"){if(toolsAmmoBottlesInOne){ȫ=true;}else{ȸ[X].CustomName+=" "+
bottleContainerKeyword;ɫ.Add(ȸ[X]);ȯ="Bottles";}}if(Ȭ){ȸ[X].CustomName+=" "+oreContainerKeyword+" "+ingotContainerKeyword;ɦ.Add(ȸ[X]);ɧ.Add(ȸ[
X]);ȯ="Ores and Ingots";}if(ȫ){ȸ[X].CustomName+=" "+toolContainerKeyword+" "+ammoContainerKeyword+" "+
bottleContainerKeyword;ɩ.Add(ȸ[X]);ɪ.Add(ȸ[X]);ɫ.Add(ȸ[X]);ȯ="Tools, Ammo and Bottles";}if(ȯ!=""){ɜ="Assigned '"+ȭ+
"' as a new container for type '"+ȯ+"'.";}ɮ="";}}void Ƞ(){for(int X=0;X<Ȳ.Count;X++){string ǡ=Ȳ[X].CustomName;string Ȉ=ǡ.ToLower();List<string>ȉ=new List
<string>();if(Ȉ.Contains(oreContainerKeyword.ToLower())&&!ǡ.Contains(oreContainerKeyword))ȉ.Add(oreContainerKeyword);if(Ȉ
.Contains(ingotContainerKeyword.ToLower())&&!ǡ.Contains(ingotContainerKeyword))ȉ.Add(ingotContainerKeyword);if(Ȉ.Contains
(componentContainerKeyword.ToLower())&&!ǡ.Contains(componentContainerKeyword))ȉ.Add(componentContainerKeyword);if(Ȉ.
Contains(toolContainerKeyword.ToLower())&&!ǡ.Contains(toolContainerKeyword))ȉ.Add(toolContainerKeyword);if(Ȉ.Contains(
ammoContainerKeyword.ToLower())&&!ǡ.Contains(ammoContainerKeyword))ȉ.Add(ammoContainerKeyword);if(Ȉ.Contains(bottleContainerKeyword.ToLower(
))&&!ǡ.Contains(bottleContainerKeyword))ȉ.Add(bottleContainerKeyword);if(Ȉ.Contains(lockedContainerKeyword.ToLower())&&!ǡ
.Contains(lockedContainerKeyword))ȉ.Add(lockedContainerKeyword);if(Ȉ.Contains(hiddenContainerKeyword.ToLower())&&!ǡ.
Contains(hiddenContainerKeyword))ȉ.Add(hiddenContainerKeyword);if(Ȉ.Contains(specialContainerKeyword.ToLower())&&!ǡ.Contains(
specialContainerKeyword))ȉ.Add(specialContainerKeyword);if(Ȉ.Contains(noSortingKeyword.ToLower())&&!ǡ.Contains(noSortingKeyword))ȉ.Add(
noSortingKeyword);if(Ȉ.Contains(manualMachineKeyword.ToLower())&&!ǡ.Contains(manualMachineKeyword))ȉ.Add(manualMachineKeyword);if(Ȉ.
Contains(autocraftingKeyword.ToLower())&&!ǡ.Contains(autocraftingKeyword))ȉ.Add(autocraftingKeyword);if(Ȉ.Contains(
assembleKeyword.ToLower())&&!ǡ.Contains(assembleKeyword))ȉ.Add(assembleKeyword);if(Ȉ.Contains(disassembleKeyword.ToLower())&&!ǡ.
Contains(disassembleKeyword))ȉ.Add(disassembleKeyword);if(Ȉ.Contains(learnKeyword.ToLower())&&!ǡ.Contains(learnKeyword))ȉ.Add(
learnKeyword);if(Ȉ.Contains(learnManyKeyword.ToLower())&&!ǡ.Contains(learnManyKeyword))ȉ.Add(learnManyKeyword);if(Ȉ.Contains(
inventoryLCDKeyword.ToLower())&&!ǡ.Contains(inventoryLCDKeyword))ȉ.Add(inventoryLCDKeyword);if(Ȉ.Contains(mainLCDKeyword.ToLower())&&!ǡ.
Contains(mainLCDKeyword))ȉ.Add(mainLCDKeyword);if(Ȉ.Contains(warningsLCDKeyword.ToLower())&&!ǡ.Contains(warningsLCDKeyword))ȉ.
Add(warningsLCDKeyword);if(Ȉ.Contains(performanceLCDKeyword.ToLower())&&!ǡ.Contains(performanceLCDKeyword))ȉ.Add(
performanceLCDKeyword);if(Ȉ.Contains("[p")&&!ǡ.Contains("[P"))ȉ.Add("[P");if(Ȉ.Contains("[pmax]")&&!ǡ.Contains("[PMax]"))ȉ.Add("[PMax]");if(Ȉ
.Contains("[pmin]")&&!ǡ.Contains("[PMin]"))ȉ.Add("[PMin]");foreach(var u in ȉ){Ȳ[X].CustomName=System.Text.
RegularExpressions.Regex.Replace(Ȳ[X].CustomName,u,u,System.Text.RegularExpressions.RegexOptions.IgnoreCase);ɜ="Corrected name\nof: '"+ǡ+
"'\nto: '"+Ȳ[X].CustomName+"'";}}List<IMyTextPanel>ƈ=new List<IMyTextPanel>();GridTerminalSystem.GetBlocksOfType(ƈ);for(int X=0;X<
ƈ.Count;X++){string ǡ=ƈ[X].CustomName;string Ȉ=ǡ.ToLower();List<string>ȉ=new List<string>();if(Ȉ.Contains(mainLCDKeyword.
ToLower())&&!ǡ.Contains(mainLCDKeyword))ȉ.Add(mainLCDKeyword);if(Ȉ.Contains(inventoryLCDKeyword.ToLower())&&!ǡ.Contains(
inventoryLCDKeyword))ȉ.Add(inventoryLCDKeyword);if(Ȉ.Contains(warningsLCDKeyword.ToLower())&&!ǡ.Contains(warningsLCDKeyword))ȉ.Add(
warningsLCDKeyword);if(Ȉ.Contains(performanceLCDKeyword.ToLower())&&!ǡ.Contains(performanceLCDKeyword))ȉ.Add(performanceLCDKeyword);
foreach(var u in ȉ){ƈ[X].CustomName=System.Text.RegularExpressions.Regex.Replace(ƈ[X].CustomName,u,u,System.Text.
RegularExpressions.RegexOptions.IgnoreCase);ɜ="Corrected name\nof: '"+ǡ+"'\nto: '"+ƈ[X].CustomName+"'";}}}void Ȋ(){if(ɲ==0)ȋ(ȇ,ɦ,
oreContainerKeyword);if(ɲ==1)ȋ(Ǧ,ɧ,ingotContainerKeyword);if(ɲ==2)ȋ(ǧ,ɨ,componentContainerKeyword);if(ɲ==3)ȋ(ǫ,ɩ,toolContainerKeyword);if(ɲ
==4)ȋ(Ǩ,ɪ,ammoContainerKeyword);if(ɲ==5)ȋ(ǩ,ɫ,bottleContainerKeyword);if(ɲ==6)ȋ(Ǫ,ɫ,bottleContainerKeyword);ɲ++;if(ɲ>6)ɲ=0
;}void ȋ(string Ȍ,List<IMyTerminalBlock>ȍ,string Ȏ){if(ȍ.Count==0){ƞ("There are no containers for type '"+Ȏ+
"'!\nBuild new ones or add the tag to existing ones!");ɮ=Ȍ;return;}IMyTerminalBlock Á=null;int ȕ=int.MaxValue;string ȏ=
"\nhas a different owner/faction!\nCan't move items from there!";for(int X=0;X<ȍ.Count;X++){if(Ȍ==ǩ&&ȍ[X].BlockDefinition.TypeIdString.Contains("OxygenTank")&&ȍ[X].BlockDefinition.
SubtypeId.Contains("Hydrogen")){continue;}else if(Ȍ==Ǫ&&ȍ[X].BlockDefinition.TypeIdString.Contains("OxygenTank")&&!ȍ[X].
BlockDefinition.SubtypeId.Contains("Hydrogen")){continue;}var U=ȍ[X].GetInventory(0);if((float)U.CurrentVolume<(float)U.MaxVolume*0.98f
){Á=ȍ[X];ȕ=V(ȍ[X]);break;}}if(Á==null){ƞ("All containers for type '"+Ȏ+
"' are full!\nYou should build new cargo containers!");ɮ=Ȍ;return;}IMyTerminalBlock Ȑ=null;if(fillBottles&&(Ȍ==ǩ||Ȍ==Ǫ)){Ȑ=ȑ(Ȍ);}for(int X=0;X<ȴ.Count;X++){if(ȴ[X]==Á||(ȴ[X]
.CustomName.Contains(Ȏ)&&V(ȴ[X])<=ȕ)||(Ȍ=="Ore"&&ȴ[X].GetType().ToString().Contains("MyGasGenerator"))){continue;}if(ȴ[X]
.CustomName.Contains(Ȏ)&&balanceTypeContainers&&!ȴ[X].BlockDefinition.TypeIdString.Contains("OxygenGenerator")&&!ȴ[X].
BlockDefinition.TypeIdString.Contains("OxygenTank"))continue;if(ȴ[X].GetOwnerFactionTag()!=Me.GetOwnerFactionTag()){ƞ("'"+ȴ[X].
CustomName+"'"+ȏ);continue;}if(Ȑ!=null){if(!ȴ[X].BlockDefinition.TypeIdString.Contains("Oxygen")){Ê(Ȍ,ȴ[X],0,Ȑ,0);continue;}}Ê(Ȍ,ȴ
[X],0,Á,0);}for(int X=0;X<ȱ.Count;X++){if(ȱ[X]==Á||(ȱ[X].CustomName.Contains(Ȏ)&&V(ȱ[X])<=ȕ)){continue;}if(ȱ[X].
GetOwnerFactionTag()!=Me.GetOwnerFactionTag()){ƞ("'"+ȱ[X].CustomName+"'"+ȏ);continue;}Ê(Ȍ,ȱ[X],1,Á,0);}for(int X=0;X<ɞ.Count;X++){if(ɞ[X].
Mode==MyAssemblerMode.Disassembly||ɞ[X]==Á||(ɞ[X].CustomName.Contains(Ȏ)&&V(ɞ[X])<=ȕ)){continue;}if(ɞ[X].GetOwnerFactionTag(
)!=Me.GetOwnerFactionTag()){ƞ("'"+ɞ[X].CustomName+"'"+ȏ);continue;}if(Ȑ!=null){Ê(Ȍ,ɞ[X],1,Ȑ,0);continue;}Ê(Ȍ,ɞ[X],1,Á,0);
}if(!ƻ())ɲ++;}IMyTerminalBlock ȑ(string Ȍ){List<IMyGasTank>Ȓ=new List<IMyGasTank>();GridTerminalSystem.GetBlocksOfType<
IMyGasTank>(Ȓ,ȓ=>ȓ.IsSameConstructAs(Me)&&!ȓ.CustomName.Contains(specialContainerKeyword)&&!ȓ.CustomName.Contains(
lockedContainerKeyword)&&ȓ.IsWorking);if(Ȍ==ǩ)Ȓ.RemoveAll(ȓ=>ȓ.BlockDefinition.SubtypeId.Contains("Hydrogen"));if(Ȍ==Ǫ)Ȓ.RemoveAll(ȓ=>!ȓ.
BlockDefinition.SubtypeId.Contains("Hydrogen"));foreach(var Ȕ in Ȓ){if(Ȕ.FilledRatio>0){Ȕ.AutoRefillBottles=true;return Ȕ;}}List<
IMyGasGenerator>Ȼ=ɡ.Where(Ȗ=>Ȗ.IsSameConstructAs(Me)&&Ȗ.Enabled==true).ToList();MyDefinitionId ɾ=MyDefinitionId.Parse(ǥ+ȇ+"/Ice");
foreach(var ˉ in Ȼ){if(G(ɾ,ˉ)>0){ˉ.AutoRefill=true;return ˉ;}}return null;}void ˊ(){char ˋ='0';char ˌ='0';char[]ˍ={'A','N','T',
'X'};char[]ˎ={'a','d'};if(sortingPattern.Length==2){ˋ=sortingPattern[0];ˌ=sortingPattern[1];}ȳ=new List<IMyTerminalBlock>(ȴ
);ȳ.AddRange(ɭ);if(enableInternalSorting){if(ˋ.ToString().IndexOfAny(ˍ)<0||ˌ.ToString().IndexOfAny(ˎ)<0){ƞ(
"You provided the invalid sorting pattern '"+sortingPattern+"'!\nCan't sort the inventories!");return;}}else{ȳ=ȳ.FindAll(X=>X.CustomName.ToLower().Contains("(sort:"
));}for(var ƃ=ɳ;ƃ<ȳ.Count;ƃ++){if(ƻ())return;if(ɳ>=ȳ.Count-1){ɳ=0;}else{ɳ++;}var U=ȳ[ƃ].GetInventory(0);var Æ=new List<
MyInventoryItem>();U.GetItems(Æ);if(Æ.Count>200)continue;char ˏ=ˋ;char ː=ˌ;string ˑ=System.Text.RegularExpressions.Regex.Match(ȳ[ƃ].
CustomName,@"(\(sort:)(.{2})",System.Text.RegularExpressions.RegexOptions.IgnoreCase).Groups[2].Value;if(ˑ.Length==2){ˋ=ˑ[0];ˌ=ˑ[1
];if(ˋ.ToString().IndexOfAny(ˍ)<0||ˌ.ToString().IndexOfAny(ˎ)<0){ƞ("You provided an invalid sorting pattern in\n'"+ȳ[ƃ].
CustomName+"'!\nUsing global pattern!");ˋ=ˏ;ˌ=ː;}}var ˠ=new List<MyInventoryItem>();U.GetItems(ˠ);if(ˋ=='A'){if(ˌ=='d'){ˠ.Sort((Ț,
ŏ)=>ŏ.Amount.ToIntSafe().CompareTo(Ț.Amount.ToIntSafe()));}else{ˠ.Sort((Ț,ŏ)=>Ț.Amount.ToIntSafe().CompareTo(ŏ.Amount.
ToIntSafe()));}}else if(ˋ=='N'){if(ˌ=='d'){ˠ.Sort((Ț,ŏ)=>ŏ.Type.SubtypeId.ToString().CompareTo(Ț.Type.SubtypeId.ToString()));}
else{ˠ.Sort((Ț,ŏ)=>Ț.Type.SubtypeId.ToString().CompareTo(ŏ.Type.SubtypeId.ToString()));}}else if(ˋ=='T'){if(ˌ=='d'){ˠ.Sort((
Ț,ŏ)=>ŏ.Type.ToString().CompareTo(Ț.Type.ToString()));}else{ˠ.Sort((Ț,ŏ)=>Ț.Type.ToString().CompareTo(ŏ.Type.ToString()))
;}}else if(ˋ=='X'){if(ˌ=='d'){ˠ.Sort((Ț,ŏ)=>(ŏ.Type.TypeId.ToString()+ŏ.Amount.ToIntSafe().ToString(@"000000000")).
CompareTo((Ț.Type.TypeId.ToString()+Ț.Amount.ToIntSafe().ToString(@"000000000"))));}else{ˠ.Sort((Ț,ŏ)=>(Ț.Type.TypeId.ToString()+
Ț.Amount.ToIntSafe().ToString(@"000000000")).CompareTo((ŏ.Type.TypeId.ToString()+ŏ.Amount.ToIntSafe().ToString(
@"000000000"))));}}if(ˠ.SequenceEqual(Æ,new ŕ()))continue;foreach(var u in ˠ){string ˡ=u.ToString();for(int X=0;X<Æ.Count;X++){if(Æ[
X].ToString()==ˡ){U.TransferItemTo(U,X,Æ.Count,false);Æ.Clear();U.GetItems(Æ);break;}}}ˋ=ˏ;ˌ=ː;}}void ˈ(){for(int ƃ=ɴ;ƃ<ɭ
.Count;ƃ++){if(ƻ())return;ɴ++;ä(ɭ[ƃ]);int J=0;if(ɭ[ƃ].BlockDefinition.SubtypeId.Contains("Assembler")){IMyAssembler Ā=ɭ[ƃ
]as IMyAssembler;if(Ā.Mode==MyAssemblerMode.Disassembly)J=1;}var Ð=ɭ[ƃ].CustomData.Split('\n');List<string>ʹ=new List<
string>();foreach(var Ñ in Ð){if(!Ñ.Contains("="))continue;MyDefinitionId H;double ʺ=0;var ʻ=Ñ.Split('=');if(ʻ.Length>=2){if(!
MyDefinitionId.TryParse(ǥ+ʻ[0],out H))continue;double.TryParse(ʻ[1],out ʺ);if(ʻ[1].ToLower().Contains("all")){ʺ=int.MaxValue;}}else{
continue;}double ʼ=G(H,ɭ[ƃ],J);double ʒ=0;if(ʺ>=0){ʒ=ʺ-ʼ;}else{ʒ=Math.Abs(ʺ)-ʼ;}if(ʒ>=1&&ʺ>=0){var U=ɭ[ƃ].GetInventory(J);if((
float)U.CurrentVolume>(float)U.MaxVolume*0.98f)continue;if(ʒ>G(H)&&ʺ!=int.MaxValue){ʹ.Add(ʒ-G(H)+" "+H.SubtypeName);}
IMyTerminalBlock M=null;if(allowSpecialSteal){M=K(H,true,ɭ[ƃ]);}else{M=K(H);}if(M!=null){Ê(H.ToString(),M,0,ɭ[ƃ],J,ʒ,true);}}else if(ʒ<0
){IMyTerminalBlock Á=O(ɭ[ƃ],ȸ);if(Á!=null)Ê(H.ToString(),ɭ[ƃ],J,Á,0,Math.Abs(ʒ),true);}}if(ʹ.Count>0){ƞ(ɭ[ƃ].CustomName+
"\nis missing the following items to match its quota:\n"+String.Join(", ",ʹ));}}ɴ=0;}void ʽ(List<IMyTerminalBlock>ó){foreach(var N in ó){string ʾ=N.CustomName;string ʿ="";var ˀ
=System.Text.RegularExpressions.Regex.Match(ʾ,@"\(\d+\.?\d*\%\)").Value;if(ˀ!=""){ʿ=ʾ.Replace(ˀ,"").TrimEnd(' ');}else{ʿ=
ʾ;}var U=N.GetInventory(0);string ǋ=((float)U.CurrentVolume).Ű((float)U.MaxVolume);if(showFillLevel){ʿ+=" ("+ǋ+")";ʿ=ʿ.
Replace("  "," ");}if(ʿ!=ʾ)N.CustomName=ʿ;}}StringBuilder ˁ(){if(ɣ.Count>1){string ˆ=@"("+autocraftingKeyword+@" *)(\d*)";ɣ.
Sort((Ț,ŏ)=>System.Text.RegularExpressions.Regex.Match(Ț.CustomName,ˆ).Groups[2].Value.CompareTo(System.Text.
RegularExpressions.Regex.Match(ŏ.CustomName,ˆ).Groups[2].Value));}StringBuilder û=new StringBuilder();if(!ɣ[0].GetText().Contains(
"Isy's Autocrafting")){ɣ[0].Font=defaultFont;ɣ[0].FontSize=defaultFontSize;}foreach(var e in ɣ){û.Append(e.GetText()+"\n");e.
WritePublicTitle("Craft item manually once to show up here");e.FontSize=ɣ[0].FontSize;e.Font=ɣ[0].Font;e.Alignment=VRage.Game.GUI.
TextPanel.TextAlignment.LEFT;e.ContentType=VRage.Game.GUI.TextPanel.ContentType.TEXT_AND_IMAGE;}List<string>ˇ=û.ToString().Split(
'\n').ToList();List<string>Ð=ɣ[0].CustomData.Split('\n').ToList();ˇ.RemoveAll(Ñ=>Ñ.IndexOfAny(ɔ)<=0);foreach(var Ë in ɤ){
bool ˢ=false;foreach(var Ñ in ˇ){string Ί=Ñ.Remove(Ñ.IndexOf(" "));if(Ί==Ë){ˢ=true;break;}}foreach(var Ñ in Ð){if(Ñ==Ë){ˢ=
true;break;}}if(!ˢ){MyDefinitionId H=ǃ(Ë);double Ό=Math.Ceiling(G(H));û.Append("\n"+Ë+" "+Ό+" = "+Ό);}}List<string>ˣ=û.
ToString().Split('\n').ToList();StringBuilder Ż=new StringBuilder();ˣ.RemoveAll(Ñ=>Ñ.IndexOfAny(ɔ)<=0);try{IOrderedEnumerable<
string>Ύ;Ύ=ˣ.OrderBy(Ț=>Ț.Substring(0,Ț.IndexOf(" ")));foreach(var Ñ in Ύ){bool Ώ=false;string Ë=Ñ.Remove(Ñ.IndexOf(" "));
string ΐ=Ñ.Replace(Ë,"");foreach(var u in ɤ){if(u==Ë){Ώ=true;break;}}if(Ώ)Ż.Append(Ë+ΐ+"\n");}}catch{}return Ż;}void Α(
StringBuilder û){if(û.Length==0){û.Append("Autocrafting error!\n\nNo items for crafting available!\n\nIf you hid all items, check the custom data of the first autocrafting panel and reenable some of them.\n\nOtherwise, store or build new items manually!"
);û=ɣ[0].Ŋ(û,2,false);ɣ[0].WriteText(û);return;}var Ĥ=û.ToString().TrimEnd('\n').Split('\n');int ĥ=Ĥ.Length;int Ħ=0;float
Γ=0;foreach(var e in ɣ){float ŵ=e.Ń();int ħ=e.ľ();int Ĩ=0;List<string>Ż=new List<string>();if(e==ɣ[0]||
headerOnEveryScreen){string Δ=ɒ;if(headerOnEveryScreen&&ɣ.Count>1){Δ+=" "+(ɣ.IndexOf(e)+1)+"/"+ɣ.Count;try{Δ+=" ["+Ĥ[Ħ][0]+"-#]";}catch{Δ+=
" [Empty]";}}Ż.Add(Δ);Ż.Add(e.ń('=',e.Š(Δ)).ToString()+"\n");string Ε="Component ";string Ζ="Current | Wanted ";Γ=e.Š("Wanted ");
string Ǐ=e.ń(' ',ŵ-e.Š(Ε)-e.Š(Ζ)).ToString();Ż.Add(Ε+Ǐ+Ζ+"\n");Ĩ=5;}while((Ħ<ĥ&&Ĩ<ħ)||(e==ɣ[ɣ.Count-1]&&Ħ<ĥ)){var Ñ=Ĥ[Ħ].Split
(' ');Ñ[0]+=" ";Ñ[1]=Ñ[1].Replace('$',' ');string Ǐ=e.ń(' ',ŵ-e.Š(Ñ[0])-e.Š(Ñ[1])-Γ).ToString();string Η=Ñ[0]+Ǐ+Ñ[1]+Ñ[2]
;Ż.Add(Η);Ħ++;Ĩ++;}if(headerOnEveryScreen&&ɣ.Count>1){Ż[0]=Ż[0].Replace('#',Ĥ[Ħ-1][0]);}e.WriteText(String.Join("\n",Ż));
}}void Β(){ɣ.Clear();GridTerminalSystem.GetBlocksOfType<IMyTextPanel>(ɣ,e=>e.IsSameConstructAs(Me)&&e.CustomName.Contains
(autocraftingKeyword));if(ɣ.Count==0)return;if(ɝ.Count==0){ƞ(
"No assemblers found!\nBuild assemblers to enable autocrafting!");return;}ʞ();List<MyDefinitionId>ͳ=new List<MyDefinitionId>();var ˣ=ˁ().ToString().TrimEnd('\n').Split('\n');
StringBuilder Ż=new StringBuilder();foreach(var Ñ in ˣ){string Ë="";try{Ë=Ñ.Substring(0,Ñ.IndexOf(" "));}catch{continue;}
MyDefinitionId H=ǃ(Ë);if(H==null)continue;double ˤ=Math.Ceiling(G(H));string ˬ=Ñ.Substring(Ñ.IndexOfAny(ɔ)+1);double ˮ=0;double.
TryParse(System.Text.RegularExpressions.Regex.Replace(ˬ,@"\D",""),out ˮ);if(ˬ.Contains("-")){if(!ɣ[0].CustomData.Contains(ɓ))ɣ[0
].CustomData=ɓ;ɣ[0].CustomData+="\n"+Ë;continue;}Ɛ(H,ˮ);double Ͱ=Math.Abs(ˮ-ˤ);bool ͱ;MyDefinitionId Ó=ƒ(H,out ͱ);double
Ͳ=Ə(Ó);if(ˤ>=ˮ+ˮ*assembleMargin&&Ͳ>0&&!Ñ.Contains("[D:")){ʮ(Ó);Ͳ=0;ɜ="Removed '"+H.SubtypeId.ToString()+
"' from the assembling queue.";}if(ˤ<=ˮ-ˮ*disassembleMargin&&Ͳ>0&&Ñ.Contains("[D:")){ʮ(Ó);Ͳ=0;ɜ="Removed '"+H.SubtypeId.ToString()+
"' from the disassembling queue.";}string Ö="";if(Ͳ>0||Ͱ>0){if(enableAutodisassembling&&ˤ>ˮ+ˮ*disassembleMargin){Ö="$[D:";}else if(enableAutocrafting&&ˤ<
ˮ-ˮ*assembleMargin){Ö="$[A:";}if(Ö!=""){if(Ͳ==0){Ö+="Wait]";}else{Ö+=Math.Round(Ͳ)+"]";}}}if(!ͱ)Ö="$[NoBP!]";string ª="";
if(ͱ&&ˬ.Contains("!")){ͳ.Add(Ó);ª="!";}string ʹ="$=$ ";if(ˤ>ˮ)ʹ="$>$ ";if(ˤ<ˮ)ʹ="$<$ ";Ż.Append(Ë+" "+ˤ+Ö+ʹ+ˮ+ª+"\n");if(Ö
.Contains("[D:Wait]")){ʵ(Ó,Ͱ);}else if(Ö.Contains("[A:Wait]")){ʳ(Ó,Ͱ);ɜ="Queued "+Ͱ+" '"+H.SubtypeId.ToString()+
"' in the assemblers.";}else if(Ö.Contains("[NoBP!]")&&ˮ>ˤ){ƞ("Can't craft\n'"+H.SubtypeId.ToString()+
"'\nThere's no blueprint stored for this item!\nTag an assembler with the '"+learnKeyword+"' keyword and queue\nit up about 100 times to learn the blueprint.");}}ʟ();ʱ(ͳ);Α(Ż);}void Ή(){if(Ⱥ.Count
>0)return;MyDefinitionId ʂ=MyDefinitionId.Parse(ǥ+ȇ+"/Stone");MyDefinitionId Ó=MyDefinitionId.Parse(Ǭ+
"StoneOreToIngotBasic");double Ͷ=G(ʂ);if(Ͷ>0){double ͷ=Math.Floor(Ͷ/500/ɠ.Count);if(ͷ<1)return;foreach(var ͺ in ɠ){if(ͺ.IsQueueEmpty)ͺ.
AddQueueItem(Ó,ͷ);}}}void ͻ(){if(ɵ==0)ɵ+=ͼ(ɦ,ȇ,true);if(ɵ==1)ɵ+=ͼ(ɧ,Ǧ,true);if(ɵ==2)ɵ+=ͼ(ɨ,ǧ,true);if(ɵ==3)ɵ+=ͼ(ɩ,ǫ,true);if(ɵ==4)ɵ
+=ͼ(ɪ,Ǩ,true);if(ɵ==5)ɵ+=ͼ(ɫ,"ContainerObject",true);ɵ++;if(ɵ>5)ɵ=0;}int ͼ(List<IMyTerminalBlock>Ȝ,string ͽ="",bool Ά=
false){if(Ά)Ȝ.RemoveAll(ś=>ś.InventoryCount==2||ś.BlockDefinition.TypeIdString.Contains("OxygenGenerator")||ś.BlockDefinition
.TypeIdString.Contains("OxygenTank"));if(Ȝ.Count<2){return 1;}Dictionary<MyItemType,double>Έ=new Dictionary<MyItemType,
double>();for(int X=0;X<Ȝ.Count;X++){var Æ=new List<MyInventoryItem>();Ȝ[X].GetInventory(0).GetItems(Æ);foreach(var u in Æ){if
(!u.Type.TypeId.ToString().Contains(ͽ))continue;MyItemType H=u.Type;if(Έ.ContainsKey(H)){Έ[H]+=(double)u.Amount;}else{Έ[H
]=(double)u.Amount;}}}Dictionary<MyItemType,double>ʸ=new Dictionary<MyItemType,double>();foreach(var u in Έ){ʸ[u.Key]=(
int)(u.Value/Ȝ.Count);}for(int ʍ=0;ʍ<Ȝ.Count;ʍ++){if(ƻ())return 0;var ʎ=new List<MyInventoryItem>();Ȝ[ʍ].GetInventory(0).
GetItems(ʎ);Dictionary<MyItemType,double>ʏ=new Dictionary<MyItemType,double>();foreach(var u in ʎ){MyItemType H=u.Type;if(ʏ.
ContainsKey(H)){ʏ[H]+=(double)u.Amount;}else{ʏ[H]=(double)u.Amount;}}double ă=0;foreach(var u in Έ){ʏ.TryGetValue(u.Key,out ă);
double ʐ=ʸ[u.Key];if(ă<=ʐ+1)continue;for(int ʑ=0;ʑ<Ȝ.Count;ʑ++){if(Ȝ[ʍ]==Ȝ[ʑ])continue;double ć=G(u.Key,Ȝ[ʑ]);if(ć>=ʐ-1)
continue;double ʒ=ʐ-ć;if(ʒ>ă-ʐ)ʒ=ă-ʐ;if(ʒ>0){ă-=Ê(u.Key.ToString(),Ȝ[ʍ],0,Ȝ[ʑ],0,ʒ,true);if(ă.Ť(ʐ-1,ʐ+1))break;}}}}return ƻ()?0:
1;}void ʓ(){if(Ⱥ.Count==0)return;if(ɽ==0)ə=ʈ(ɘ,ȼ);if(ɽ==1)ɛ=ʈ(ɘ,Ƚ);if(enableScriptRefineryFilling){if(ɽ==2)ʚ(ȼ,ə);if(ɽ==3
)ʚ(Ƚ,ɛ);if(ɽ==4)ɿ(ȼ,ə);if(ɽ==5)ɿ(Ƚ,ɛ);if(ɽ==6&&ȼ.Count>0&&Ƚ.Count>0){bool ʔ=false;ʔ=ʅ(ȼ,Ƚ,ə);if(!ʔ)ʅ(Ƚ,ȼ,ɛ);}}else{if(ɽ>1
)ɽ=6;}ɽ++;if(ɽ>6)ɽ=0;}void ʕ(){if(ɬ==0)ɬ+=ͼ(ȼ.ToList<IMyTerminalBlock>());if(ɬ==1)ɬ+=ͼ(Ƚ.ToList<IMyTerminalBlock>());ɬ++;
if(ɬ>1)ɬ=0;}void ʖ(List<IMyRefinery>ʜ,List<MyItemType>ʁ){foreach(IMyRefinery Î in ʜ){var U=Î.GetInventory(0);var Æ=new
List<MyInventoryItem>();U.GetItems(Æ);if(Æ.Count<2)continue;bool ʗ=false;int ʘ=0;string ʙ="";foreach(var ʃ in ʁ){for(int X=0
;X<Æ.Count;X++){if(Æ[X].Type==ʃ){ʘ=X;ʙ=ʃ.SubtypeId;ʗ=true;break;}if(ʃ.SubtypeId=="Iron"||ʃ.SubtypeId=="Nickel"||ʃ.
SubtypeId=="Silicon"){if(Æ[X].Type.SubtypeId=="Stone"){ʘ=X;ʙ="Stone";ʗ=true;}}}if(ʗ)break;}if(ʘ!=0){U.TransferItemTo(U,ʘ,0,true);
ɜ="Sorted the refining queue.\n'"+ʙ+"' is now at the front of the queue.";}}}void ʚ(List<IMyRefinery>ʀ,List<MyItemType>ʁ)
{if(ʀ.Count==0){ɽ++;return;}MyItemType ʛ=new MyItemType();foreach(var ʃ in ʁ){if(G(ʃ)>100){ʛ=ʃ;break;}}if(!ʛ.ToString().
Contains(ȇ))return;for(int X=0;X<ʀ.Count;X++){if(ƻ())return;var U=ʀ[X].GetInventory(0);if((float)U.CurrentVolume>(float)U.
MaxVolume*0.75f){var Æ=new List<MyInventoryItem>();U.GetItems(Æ);foreach(var u in Æ){if(u.Type==ʛ)return;if(ʛ.SubtypeId=="Iron"||
ʛ.SubtypeId=="Nickel"||ʛ.SubtypeId=="Silicon"){if(u.Type.SubtypeId=="Stone")return;}}IMyTerminalBlock Á=O(ʀ[X],ɦ);if(Á!=
null){Ê("",ʀ[X],0,Á,0);}}}if(!ƻ())ɽ++;}void ɿ(List<IMyRefinery>ʀ,List<MyItemType>ʁ){if(ʀ.Count==0){ɽ++;return;}var ó=new
List<IMyTerminalBlock>();ó.AddRange(ȴ);ó.AddRange(ɭ);MyItemType ʂ=MyItemType.MakeOre("Stone");foreach(var ʃ in ʁ){MyItemType
H=ʃ;if(G(ʃ)==0){if(ʃ.SubtypeId=="Iron"||ʃ.SubtypeId=="Nickel"||ʃ.SubtypeId=="Silicon"){if(G(ʂ)>0){H=ʂ;}else{continue;}}
else{continue;}}IMyTerminalBlock ʄ=K(H,true);if(ʄ==null)continue;for(int X=0;X<ʀ.Count;X++){if(ƻ())return;var U=ʀ[X].
GetInventory(0);if((float)U.CurrentVolume>(float)U.MaxVolume*0.98f)continue;Ê(H.ToString(),ʄ,0,ʀ[X],0);}}if(!ƻ())ɽ++;}bool ʅ(List<
IMyRefinery>ʆ,List<IMyRefinery>ʇ,List<MyItemType>ʁ){for(int X=0;X<ʆ.Count;X++){if((float)ʆ[X].GetInventory(0).CurrentVolume>0.05f)
continue;for(int Ɖ=0;Ɖ<ʇ.Count;Ɖ++){if((float)ʇ[Ɖ].GetInventory(0).CurrentVolume>0){foreach(var ʃ in ʁ){Ê(ʃ.ToString(),ʇ[Ɖ],0,ʆ[
X],0,-0.5);}return true;}}}return false;}List<MyItemType>ʈ(List<string>ʉ,List<IMyRefinery>ʀ){if(ʀ.Count==0){ɽ++;return
null;}List<string>ʊ=new List<string>(ʉ);ʊ.Sort((Ț,ŏ)=>(G(MyDefinitionId.Parse(ǥ+Ǧ+"/"+Ț))/ƍ(Ț)).CompareTo((G(MyDefinitionId.
Parse(ǥ+Ǧ+"/"+ŏ))/ƍ(ŏ))));ʊ.InsertRange(0,fixedRefiningList);List<MyItemType>ʋ=new List<MyItemType>();MyItemType H;foreach(
var u in ʊ){H=MyItemType.MakeOre(u);foreach(var Î in ʀ){if(Î.GetInventory(0).CanItemsBeAdded(1,H)){ʋ.Add(H);break;}}}if(!ƻ(
))ɽ++;return ʋ;}void ʌ(){foreach(var Ā in ɝ){if(Ā.GetOwnerFactionTag()==Me.GetOwnerFactionTag()){var U=Ā.GetInventory(0);
if((float)U.CurrentVolume==0)continue;if(Ā.IsQueueEmpty||Ā.Mode==MyAssemblerMode.Disassembly||(float)U.CurrentVolume>(
float)U.MaxVolume*0.98f){IMyTerminalBlock Á=O(Ā,ɧ);if(Á!=null)Ê("",Ā,0,Á,0);}}}}void ʝ(){foreach(IMyAssembler Ā in ɝ){if(Ā.
Mode==MyAssemblerMode.Disassembly)continue;if(Ā.CustomData.Contains("skipQueueSorting")){Ā.CustomData="";continue;}var Ö=new
List<MyProductionItem>();Ā.GetQueue(Ö);if(Ö.Count<2)continue;double ʯ=Double.MaxValue;int ʘ=0;string ʙ="";for(int X=0;X<Ö.
Count;X++){MyDefinitionId H=Ɣ(Ö[X].BlueprintId);double ʰ=G(H);if(ʰ<ʯ){ʯ=ʰ;ʘ=X;ʙ=H.SubtypeId.ToString();}}if(ʘ!=0){Ā.
MoveQueueItemRequest(Ö[ʘ].ItemId,0);ɜ="Sorted the assembling queue.\n'"+ʙ+"' is now at the front of the queue.";}}}void ʱ(List<
MyDefinitionId>ʲ){if(ʲ.Count==0)return;if(ʲ.Count>1)ʲ.Sort((Ț,ŏ)=>G(Ɣ(Ț)).CompareTo(G(Ɣ(ŏ))));foreach(var Ā in ɝ){var Ö=new List<
MyProductionItem>();Ā.GetQueue(Ö);if(Ö.Count<2)continue;foreach(var Ó in ʲ){int ƃ=Ö.FindIndex(X=>X.BlueprintId==Ó);if(ƃ==-1)continue;if(
ƃ==0){Ā.CustomData="skipQueueSorting";break;}Ā.MoveQueueItemRequest(Ö[ƃ].ItemId,0);Ā.CustomData="skipQueueSorting";ɜ=
"Sorted the assembler queue by priority.\n'"+Ɣ(Ó).SubtypeId.ToString()+"' is now at the front of the queue.";break;}}}void ʳ(MyDefinitionId Ó,double w){List<
IMyAssembler>ʴ=new List<IMyAssembler>();foreach(IMyAssembler Ā in ɝ){if(Ā.CustomName.Contains(disassembleKeyword))continue;if(Ā.Mode
==MyAssemblerMode.Disassembly&&!Ā.IsQueueEmpty)continue;if(Ā.Mode==MyAssemblerMode.Disassembly){Ā.Mode=MyAssemblerMode.
Assembly;}if(Ā.CanUseBlueprint(Ó)){ʴ.Add(Ā);}}ʶ(ʴ,Ó,w);}void ʵ(MyDefinitionId Ó,double w){List<IMyAssembler>ʴ=new List<
IMyAssembler>();foreach(IMyAssembler Ā in ɝ){if(Ā.CustomName.Contains(assembleKeyword))continue;if(Ā.Mode==MyAssemblerMode.Assembly
&&Ā.IsProducing)continue;if(Ā.Mode==MyAssemblerMode.Assembly){Ā.ClearQueue();Ā.Mode=MyAssemblerMode.Disassembly;}if(Ā.Mode
==MyAssemblerMode.Assembly)continue;if(Ā.CanUseBlueprint(Ó)){ʴ.Add(Ā);}}ʶ(ʴ,Ó,w);}void ʶ(List<IMyAssembler>ʴ,
MyDefinitionId Ó,double w){if(ʴ.Count==0)return;double ʷ=Math.Ceiling(w/ʴ.Count);foreach(IMyAssembler Ā in ʴ){if(ʷ>w)ʷ=Math.Ceiling(w)
;if(w>0){Ā.InsertQueueItem(0,Ó,ʷ);w-=ʷ;}else{break;}}}void ʮ(MyDefinitionId Ó){foreach(IMyAssembler Ā in ɝ){var Ö=new
List<MyProductionItem>();Ā.GetQueue(Ö);for(int X=0;X<Ö.Count;X++){if(Ö[X].BlueprintId==Ó)Ā.RemoveQueueItem(X,Ö[X].Amount);}}
}void ʞ(){foreach(IMyAssembler Ā in ɝ){Ā.UseConveyorSystem=true;Ā.CooperativeMode=false;Ā.Repeating=false;}}void ʟ(){List
<IMyAssembler>ʠ=new List<IMyAssembler>(ɝ);ʠ.RemoveAll(Ț=>Ț.IsQueueEmpty);if(ʠ.Count==0)return;List<IMyAssembler>ʡ=new
List<IMyAssembler>(ɝ);ʡ.RemoveAll(Ț=>!Ț.IsQueueEmpty);foreach(var ʢ in ʠ){if(ʡ.Count==0)return;var Ö=new List<
MyProductionItem>();ʢ.GetQueue(Ö);double ʣ=(double)Ö[0].Amount;if(ʣ<=10)continue;double ʤ=Math.Ceiling(ʣ/2);foreach(var ʥ in ʡ){if(!ʥ.
CanUseBlueprint(Ö[0].BlueprintId))continue;if(ʢ.Mode==MyAssemblerMode.Assembly&&ʥ.CustomName.Contains(disassembleKeyword))continue;if(ʢ
.Mode==MyAssemblerMode.Disassembly&&ʥ.CustomName.Contains(assembleKeyword))continue;ʥ.Mode=ʢ.Mode;if(ʥ.Mode!=ʢ.Mode)
continue;ʥ.AddQueueItem(Ö[0].BlueprintId,ʤ);ʢ.RemoveQueueItem(0,ʤ);ʡ.Remove(ʥ);break;}}}void ʬ(){if(ɡ.Count==0)return;double ų=
iceFillLevelPercentage/100;MyDefinitionId ɾ=MyDefinitionId.Parse(ǥ+ȇ+"/Ice");string ʦ=ɾ.ToString();double ʧ=0.00037;foreach(IMyGasGenerator Ǒ
in ɡ){var U=Ǒ.GetInventory(0);double ʨ=G(ɾ,Ǒ);double ʩ=ʨ*ʧ;double ʪ=(double)U.MaxVolume;if(ʩ>ʪ*(ų+0.001)){IMyTerminalBlock
Á=O(Ǒ,ɦ);if(Á!=null){double Ĕ=(ʩ-ʪ*ų)/ʧ;Ê(ʦ,Ǒ,0,Á,0,Ĕ);}}else if(ʩ<ʪ*(ų-0.001)){IMyTerminalBlock M=K(ɾ,true);if(M!=null){
double Ĕ=(ʪ*ų-ʩ)/ʧ;Ê(ʦ,M,0,Ǒ,0,Ĕ);}}}double ʫ=0;double ʭ=0;foreach(var Ǒ in ɡ){ʫ+=G(ɾ,Ǒ);var U=Ǒ.GetInventory(0);ʭ+=(double)U.
MaxVolume;}double Ù=(ʫ*ʧ)/ʭ;foreach(var Ă in ɡ){var Ä=Ă.GetInventory(0);double ă=G(ɾ,Ă);double Ą=ă*ʧ;double ą=(double)Ä.MaxVolume
;if(Ą>ą*(Ù+0.001)){foreach(var Ć in ɡ){if(Ă==Ć)continue;var Å=Ć.GetInventory(0);double ć=G(ɾ,Ć);double Ĉ=ć*ʧ;double ĉ=(
double)Å.MaxVolume;if(Ĉ<ĉ*(Ù-0.001)){double Ċ=((ĉ*Ù)-Ĉ)/ʧ;if((ă-Ċ)*ʧ>=ą*Ù&&Ċ>5){ă-=Ê(ʦ,Ă,0,Ć,0,Ċ);continue;}if((ă-Ċ)*ʧ<ą*Ù&&Ċ>
5){double ċ=(ă*ʧ-ą*Ù)/ʧ;Ê(ʦ,Ă,0,Ć,0,ċ);break;}}}}}}void Č(){if(ɢ.Count==0)return;MyDefinitionId č=MyDefinitionId.Parse(ǥ+
Ǧ+"/Uranium");string ď=č.ToString();double ě=0;double Đ=0;foreach(IMyReactor đ in ɢ){đ.UseConveyorSystem=false;double Ē=G
(č,đ);double ē=uraniumAmountLargeGrid;if(đ.CubeGrid.GridSize==0.5f)ē=uraniumAmountSmallGrid;Đ+=ē;if(Ē>ē+0.05){
IMyTerminalBlock Á=O(đ,ɧ);if(Á!=null){double Ĕ=Ē-ē;Ê(ď,đ,0,Á,0,Ĕ);}}else if(Ē<ē-0.05){IMyTerminalBlock M=K(č,true);if(M!=null){double Ĕ=
ē-Ē;Ê(ď,M,0,đ,0,Ĕ);}}ě+=G(č,đ);}double ĕ=ě/Đ;foreach(var Ė in ɢ){double ė=G(č,Ė);double Ę=ĕ*uraniumAmountLargeGrid;if(Ė.
CubeGrid.GridSize==0.5f)Ę=ĕ*uraniumAmountSmallGrid;if(ė>Ę+0.05){foreach(var ę in ɢ){if(Ė==ę)continue;double Ě=G(č,ę);double Ĝ=ĕ*
uraniumAmountLargeGrid;if(ę.CubeGrid.GridSize==0.5f)Ĝ=ĕ*uraniumAmountSmallGrid;if(Ě<Ĝ-0.05){ė=G(č,Ė);double Ď=Ĝ-Ě;if(ė-Ď>=Ę){Ê(ď,Ė,0,ę,0,Ď);
continue;}if(ė-Ď<Ę){Ď=ė-Ę;Ê(ď,Ė,0,ę,0,Ď);break;}}}}}}StringBuilder ā(IMyTextSurface e,bool ì=true,bool í=true,bool î=true,bool ë
=true,bool ï=true){bool ð=false;StringBuilder q=new StringBuilder();if(ì){q.Append("Isy's Inventory Manager\n");q.Append(
e.ń('=',e.Š(q))).Append("\n\n");}if(í&&Ĳ!=null){q.Append("Warning!\n"+Ĳ+"\n\n");ð=true;}if(î){q.Append(ò(e,ɦ,"Ores"));q.
Append(ò(e,ɧ,"Ingots"));q.Append(ò(e,ɨ,"Components"));q.Append(ò(e,ɩ,"Tools"));q.Append(ò(e,ɪ,"Ammo"));q.Append(ò(e,ɫ,
"Bottles"));q.Append("=> "+ȶ.Count+" type containers: Balancing "+(balanceTypeContainers?"ON":"OFF")+"\n\n");ð=true;}if(ë){q.
Append("Managed blocks:\n");float ñ=e.Š(Ȳ.Count.ToString());q.Append(Ȳ.Count+" Inventories (total) / "+ȴ.Count+" sortable\n");
if(ɭ.Count>0){q.Append(e.ń(' ',ñ-e.Š(ɭ.Count.ToString())).ToString()+ɭ.Count+" Special Containers\n");}if(Ⱥ.Count>0){q.
Append(e.ń(' ',ñ-e.Š(Ⱥ.Count.ToString())).ToString()+Ⱥ.Count+" Refineries: ");q.Append("Ore Balancing "+(enableOreBalancing?
"ON":"OFF")+"\n");}if(ɡ.Count>0){q.Append(e.ń(' ',ñ-e.Š(ɡ.Count.ToString())).ToString()+ɡ.Count+" O2/H2 Generators: ");q.
Append("Ice Balancing "+(enableIceBalancing?"ON":"OFF")+"\n");}if(ɢ.Count>0){q.Append(e.ń(' ',ñ-e.Š(ɢ.Count.ToString())).
ToString()+ɢ.Count+" Reactors: ");q.Append("Uranium Balancing "+(enableUraniumBalancing?"ON":"OFF")+"\n");}if(ɝ.Count>0){q.
Append(e.ń(' ',ñ-e.Š(ɝ.Count.ToString())).ToString()+ɝ.Count+" Assemblers: ");q.Append("Craft "+(enableAutocrafting?"ON":"OFF"
)+" | ");q.Append("Uncraft "+(enableAutodisassembling?"ON":"OFF")+" | ");q.Append("Cleanup "+(enableAssemblerCleanup?"ON"
:"OFF")+"\n");}if(ɠ.Count>0){q.Append(e.ń(' ',ñ-e.Š(ɠ.Count.ToString())).ToString()+ɠ.Count+" Survival Kits: ");q.Append(
"Ingot Crafting "+(enableBasicIngotCrafting?"ON":"OFF")+(Ⱥ.Count>0?" (Auto OFF - refineries exist)":"")+"\n");}q.Append("\n");ð=true;}if(
ï&&ɜ!=""){q.Append("Last Action:\n"+ɜ);ð=true;}if(!ð){q.Append("-- No informations to show --");}return q;}StringBuilder
ò(IMyTextSurface e,List<IMyTerminalBlock>ó,string É){double ô=0,õ=0;foreach(var N in ó){var U=N.GetInventory(0);ô+=(
double)U.CurrentVolume;õ+=(double)U.MaxVolume;}string v=ó.Count+"x "+É+":";string ö=ô.ŭ();string ø=õ.ŭ();StringBuilder ù=Ǆ(e,v
,ô,õ,ö,ø);return ù;}void ú(string û=null){if(ȿ.Count==0){ɏ++;return;}for(int X=ɶ;X<ȿ.Count;X++){if(ƻ())return;ɶ++;var ü=ȿ
[X].ż(mainLCDKeyword);foreach(var ý in ü){var þ=ý.Key;var ÿ=ý.Value;if(!þ.GetText().EndsWith("\a")){þ.Font=defaultFont;þ.
FontSize=defaultFontSize;þ.Alignment=VRage.Game.GUI.TextPanel.TextAlignment.LEFT;þ.ContentType=VRage.Game.GUI.TextPanel.
ContentType.TEXT_AND_IMAGE;}bool ì=ÿ.Ɔ("showHeading");bool í=ÿ.Ɔ("showWarnings");bool î=ÿ.Ɔ("showContainerStats");bool ë=ÿ.Ɔ(
"showManagedBlocks");bool ï=ÿ.Ɔ("showLastAction");bool ĝ=ÿ.Ɔ("scrollTextIfNeeded");StringBuilder q=new StringBuilder();if(û!=null){q.Append
(û);}else{q=ā(þ,ì,í,î,ë,ï);}q=þ.Ŋ(q,ì?3:0,ĝ);þ.WriteText(q.Append("\a"));}}ɏ++;ɶ=0;}void į(){if(ɀ.Count==0){ɏ++;return;}
StringBuilder İ=new StringBuilder();if(Ɉ.Count==0){İ.Append("- No problems detected -");}else{int ı=1;foreach(var Ĳ in Ɉ){İ.Append(ı+
". "+Ĳ.Replace("\n"," ")+"\n");ı++;}}for(int X=ɷ;X<ɀ.Count;X++){if(ƻ())return;ɷ++;var ü=ɀ[X].ż(warningsLCDKeyword);foreach(
var ý in ü){var þ=ý.Key;var ÿ=ý.Value;if(!þ.GetText().EndsWith("\a")){þ.Font=defaultFont;þ.FontSize=defaultFontSize;þ.
Alignment=VRage.Game.GUI.TextPanel.TextAlignment.LEFT;þ.ContentType=VRage.Game.GUI.TextPanel.ContentType.TEXT_AND_IMAGE;}bool ì=ÿ
.Ɔ("showHeading");bool ĝ=ÿ.Ɔ("scrollTextIfNeeded");StringBuilder q=new StringBuilder();if(ì){q.Append(
"Isy's Inventory Manager Warnings\n");q.Append(þ.ń('=',þ.Š(q))).Append("\n\n");}q.Append(İ);q=þ.Ŋ(q,ì?3:0,ĝ);þ.WriteText(q.Append("\a"));}}ɏ++;ɷ=0;}void ĳ()
{if(Ɂ.Count==0){ɏ++;return;}for(int X=ɸ;X<Ɂ.Count;X++){if(ƻ())return;ɸ++;var ü=Ɂ[X].ż(performanceLCDKeyword);foreach(var
ý in ü){var þ=ý.Key;var ÿ=ý.Value;if(!þ.GetText().EndsWith("\a")){þ.Font=defaultFont;þ.FontSize=defaultFontSize;þ.
Alignment=VRage.Game.GUI.TextPanel.TextAlignment.LEFT;þ.ContentType=VRage.Game.GUI.TextPanel.ContentType.TEXT_AND_IMAGE;}bool ì=ÿ
.Ɔ("showHeading");bool ĝ=ÿ.Ɔ("scrollTextIfNeeded");StringBuilder q=new StringBuilder();if(ì){q.Append(
"Isy's Inventory Manager Performance\n");q.Append(þ.ń('=',þ.Š(q))).Append("\n\n");}q.Append(ƭ);q=þ.Ŋ(q,ì?3:0,ĝ);þ.WriteText(q.Append("\a"));}}ɏ++;ɸ=0;}void ĵ()
{if(ɂ.Count==0){ɏ++;return;}Dictionary<IMyTextSurface,string>Ķ=new Dictionary<IMyTextSurface,string>();Dictionary<
IMyTextSurface,string>ķ=new Dictionary<IMyTextSurface,string>();List<IMyTextSurface>ĸ=new List<IMyTextSurface>();List<IMyTextSurface>Ĺ
=new List<IMyTextSurface>();foreach(var I in ɂ){var ü=I.ż(inventoryLCDKeyword);foreach(var ý in ü){if(ý.Value.Contains(
inventoryLCDKeyword+":")){Ķ[ý.Key]=ý.Value;ĸ.Add(ý.Key);}else{ķ[ý.Key]=ý.Value;Ĺ.Add(ý.Key);}}}HashSet<string>ĺ=new HashSet<string>();
foreach(var þ in Ķ){ĺ.Add(System.Text.RegularExpressions.Regex.Match(þ.Value,inventoryLCDKeyword+@":[A-Za-z]+").Value);}ĺ.
RemoveWhere(Ĵ=>Ĵ=="");List<string>Į=ĺ.ToList();for(int X=ɹ;X<Į.Count;X++){if(ƻ())return;ɹ++;var Ğ=Ķ.Where(ğ=>ğ.Value.Contains(Į[X])
);var Ġ=from pair in Ğ orderby System.Text.RegularExpressions.Regex.Match(pair.Value,inventoryLCDKeyword+@":\w+").Value
ascending select pair;IMyTextSurface ġ=Ġ.ElementAt(0).Key;string ÿ=Ġ.ElementAt(0).Value;StringBuilder q=ĩ(ġ,ÿ);if(!ÿ.ToLower().
Contains("noscroll")){int Ģ=0;foreach(var ģ in Ġ){Ģ+=ģ.Key.ľ();}q=ġ.Ŋ(q,0,true,Ģ);}var Ĥ=q.ToString().Split('\n');int ĥ=Ĥ.Length
;int Ħ=0;int ħ,Ĩ;foreach(var ģ in Ġ){IMyTextSurface þ=ģ.Key;þ.FontSize=ġ.TextureSize.Y/þ.TextureSize.Y*ġ.FontSize;þ.Font=
ġ.Font;þ.TextPadding=ġ.TextPadding;þ.Alignment=VRage.Game.GUI.TextPanel.TextAlignment.LEFT;þ.ContentType=VRage.Game.GUI.
TextPanel.ContentType.TEXT_AND_IMAGE;ħ=þ.ľ();Ĩ=0;q.Clear();while(Ħ<ĥ&&Ĩ<ħ){q.Append(Ĥ[Ħ]+"\n");Ħ++;Ĩ++;}þ.WriteText(q);}}for(int
X=ɺ;X<Ĺ.Count;X++){if(ƻ())return;ɺ++;IMyTextSurface þ=Ĺ[X];string ÿ=ķ[þ];StringBuilder q=ĩ(þ,ÿ);if(!ÿ.ToLower().Contains(
"noscroll")){q=þ.Ŋ(q,0);}þ.WriteText(q);þ.Alignment=VRage.Game.GUI.TextPanel.TextAlignment.LEFT;þ.ContentType=VRage.Game.GUI.
TextPanel.ContentType.TEXT_AND_IMAGE;}ɏ++;ɹ=0;ɺ=0;}StringBuilder ĩ(IMyTextSurface e,string ÿ){StringBuilder q=new StringBuilder()
;var Ī=ÿ.Split('\n').ToList();Ī.RemoveAll(ī=>ī.StartsWith("@")||ī.Length<=1);bool Ĭ=true;try{if(Ī[0].Length<=1)Ĭ=false;}
catch{Ĭ=false;}if(!Ĭ){q.Append("Put an item or type name in the custom data.\n\n"+
"Examples:\nComponent\nIngot\nSteelPlate\nInteriorPlate\n\n"+"Optionally, add a max amount for the bars as a 2nd parameter.\n\n"+"Example:\nIngot 100000\n\n"+
"At last, add any of these modifiers.\n"+"There are 5 modifiers at this point:\n\n"+"'noHeading' to hide the heading\n"+
"'singleLine' to force one line per item\n"+"'noBar' to hide the bars\n"+"'noScroll' to prevent the text from scrolling\n"+
"'hideEmpty' to hide items that have an amount of 0\n\n"+"Examples:\nComponent 100000 noBar\nSteelPlate noHeading noBar hideEmpty\n\n"+
"To display multiple different items, use a new line for every item!\n\n"+"Hint: One 'noScroll' modifier per screen is enough!\n\n");e.Font=defaultFont;e.FontSize=defaultFontSize;}else{foreach(
var Ñ in Ī){var ĭ=Ñ.Split(' ');double h=-1;bool k=false;bool m=false;bool o=false;bool d=false;if(ĭ.Length>=2){try{h=
Convert.ToDouble(ĭ[1]);}catch{h=-1;}}if(Ñ.ToLower().Contains("noheading"))k=true;if(Ñ.ToLower().Contains("nobar"))m=true;if(Ñ.
ToLower().Contains("hideempty"))o=true;if(Ñ.ToLower().Contains("singleline"))d=true;q.Append(Ì(e,ĭ[0],h,k,m,o,d));if(Ī.Count>1
&&Ñ!=Ī[Ī.Count-1])q.Append("\n");}}return q;}StringBuilder Ì(IMyTextSurface e,string f,double h,bool k=false,bool m=false,
bool o=false,bool d=false){StringBuilder q=new StringBuilder();bool r=h==-1?true:false;foreach(var u in ǭ){if(u.ToString().
ToLower().Contains(f.ToLower())){if(q.Length==0&&!k){string v="Items containing '"+char.ToUpper(f[0])+f.Substring(1).ToLower()+
"'\n\n";q.Append(e.ń(' ',(e.Ń()-e.Š(v))/2)).Append(v);}double w=G(u);if(w==0&&o)continue;if(r)h=Ƒ(u);q.Append(Ǆ(e,u.SubtypeId.
ToString(),w,h,w.ů(),h.ů(),m,d));}}if(q.Length==0){q.Append("Error!\n\n");q.Append("No items containing '"+f+
"' found!\nCheck the custom data of this LCD and enter a valid type or item name!\n");}return q;}void z(){if(ƴ==99){ƴ=0;}else{ƴ++;}Echo("Isy's Inventory Manager "+Ɋ[Ⱦ]+"\n====================\n");if(Ĳ!=
null){Echo("Warning!\n"+Ĳ+"\n");}StringBuilder q=new StringBuilder();q.Append("Script is running in "+(Ǽ?"station":"ship")+
" mode\n\n");q.Append("Task: "+ȅ[Ɍ]+"\n");q.Append("Script step: "+Ɍ+" / "+(ȅ.Length-1)+"\n\n");ƭ=q.Append(ƭ);if(ɥ.Count>0){ƭ.
Append("Excluded grids:\n============\n\n");foreach(var µ in ɥ){ƭ.Append(µ.CustomName+"\n");}}Echo(ƭ.ToString());if(ȿ.Count==0
){Echo("Hint:\nBuild a LCD and add the main LCD\nkeyword '"+mainLCDKeyword+
"' to its name to get\nmore informations about your base\nand the current script actions.\n");}}double Ê(string º,IMyTerminalBlock M,int À,IMyTerminalBlock Á,int Â,double w=-1,bool Ã=false){var Ä=M.GetInventory(À
);var Å=Á.GetInventory(Â);if(!Ä.IsConnectedTo(Å))return 0;if((float)Å.CurrentVolume>(float)Å.MaxVolume*0.98f)return 0;var
Æ=new List<MyInventoryItem>();Ä.GetItems(Æ);if(Æ.Count==0)return 0;double Ç=0;MyDefinitionId H=new MyDefinitionId();
MyDefinitionId È=new MyDefinitionId();string É="";string Ë="";bool Z=false;string A="";if(w==-0.5)A="halfInventory";if(w==-1)A=
"completeInventory";for(int X=Æ.Count-1;X>=0;X--){H=Æ[X].Type;if(Ã?H.ToString()==º:H.ToString().Contains(º)){if(A!=""&&H!=È)Ç=0;È=H;É=H.
TypeId.ToString().Replace(ǥ,"");Ë=H.SubtypeId.ToString();Z=true;if(!Ä.CanTransferItemTo(Å,H)){ƞ("'"+Ë+
"' couldn't be transferred\nfrom '"+M.CustomName+"'\nto '"+Á.CustomName+"'\nThe conveyor type is too small!");return 0;}double B=(double)Æ[X].Amount;double
C=0;if(A=="completeInventory"){Ä.TransferItemTo(Å,X,null,true);}else if(A=="halfInventory"){double D=Math.Ceiling((double
)Æ[X].Amount/2);Ä.TransferItemTo(Å,X,null,true,(VRage.MyFixedPoint)D);}else{if(!É.Contains(Ǧ))w=Math.Ceiling(w);Ä.
TransferItemTo(Å,X,null,true,(VRage.MyFixedPoint)w);}Æ.Clear();Ä.GetItems(Æ);try{if((MyDefinitionId)Æ[X].Type==H){C=(double)Æ[X].
Amount;}}catch{C=0;}double E=B-C;Ç+=E;w-=E;if(w<=0&&A=="")break;}}if(!Z)return 0;if(Ç>0){string F=Math.Round(Ç,2)+" "+Ë+" "+É;
ɜ="Moved: "+F+"\nfrom: '"+M.CustomName+"'\nto: '"+Á.CustomName+"'";}else{string F=Math.Round(w,2)+" "+º.Replace(ǥ,"");if(
A=="completeInventory")F="all items";if(A=="halfInventory")F="half of the items";ƞ("Couldn't move '"+F+"'\nfrom '"+M.
CustomName+"'\nto '"+Á.CustomName+"'\nCheck conveyor connection and owner/faction!");}return Ç;}double G(MyDefinitionId H,
IMyTerminalBlock I,int J=0){return(double)I.GetInventory(J).GetItemAmount(H);;}IMyTerminalBlock K(MyDefinitionId H,bool L=false,
IMyTerminalBlock M=null){try{if(ɱ.GetInventory(0).FindItem(H)!=null){return ɱ;}}catch{}foreach(var N in ȴ){if(H.SubtypeId.ToString()==
"Ice"&&N.GetType().ToString().Contains("MyGasGenerator"))continue;if(N.GetInventory(0).FindItem(H)!=null){ɱ=N;return N;}}if(L
){foreach(var N in ɭ){if(M!=null){if(V(N)<=V(M))continue;}if(N.GetInventory(0).FindItem(H)!=null){ɱ=N;return N;}}}return
null;}IMyTerminalBlock O(IMyTerminalBlock P,List<IMyTerminalBlock>Q){IMyTerminalBlock R=null;R=S(P,Q);if(R!=null)return R;R=
S(P,ȵ);if(R==null)ƞ("'"+P.CustomName+"'\nhas no empty containers to move its items!");return R;}IMyTerminalBlock S(
IMyTerminalBlock P,List<IMyTerminalBlock>Q){var T=P.GetInventory(0);foreach(var N in Q){if(N==P)continue;var U=N.GetInventory(0);if((
float)U.CurrentVolume<(float)U.MaxVolume*0.95f){if(!N.GetInventory(0).IsConnectedTo(T))continue;return N;}}return null;}int V
(IMyTerminalBlock I){string W=System.Text.RegularExpressions.Regex.Match(I.CustomName,@"\[p(\d+|max|min)\]",System.Text.
RegularExpressions.RegexOptions.IgnoreCase).Groups[1].Value.ToLower();int ª=0;bool Y=true;if(W=="max"){ª=int.MinValue;}else if(W=="min"){ª
=int.MaxValue;}else{Y=Int32.TryParse(W,out ª);}if(!Y){string µ=I.IsSameConstructAs(Me)?"":"1";Int32.TryParse(µ+I.EntityId
.ToString().Substring(0,4),out ª);}return ª;}void Ú(IMyTerminalBlock I,int Û){string Ü=System.Text.RegularExpressions.
Regex.Match(I.CustomName,@"\[p(\d+|max|min)\]",System.Text.RegularExpressions.RegexOptions.IgnoreCase).Value;string Ý="";if(Û
==int.MaxValue){Ý="[PMax]";}else if(Û==int.MinValue){Ý="[PMin]";}else{Ý="[P"+Û+"]";}if(Ü==Ý){return;}else if(Ü!=""){I.
CustomName=I.CustomName.Replace(Ü,Ý);}else{I.CustomName=I.CustomName+" "+Ý;}}string Þ(string ß){ã();var à=Storage.Split('\n');
foreach(var Ñ in à){if(Ñ.Contains(ß)){return Ñ.Replace(ß+"=","");}}return"";}void á(string ß,string Û=""){ã();var à=Storage.
Split('\n');string â="";foreach(var Ñ in à){if(Ñ.Contains(ß)){â+=ß+"="+Û+"\n";}else{â+=Ñ+"\n";}}Storage=â.TrimEnd('\n');}void
ã(){var à=Storage.Split('\n');if(à.Length!=ɑ.Count){string â="";foreach(var u in ɑ){â+=u.Key+"="+u.Value+"\n";}Storage=â.
TrimEnd('\n');}}void ä(IMyTerminalBlock N){foreach(var å in ǻ.Keys.ToList()){ǻ[å]="0";}List<string>æ=N.CustomData.Replace(" ",
"").TrimEnd('\n').Split('\n').ToList();æ.RemoveAll(Ñ=>!Ñ.Contains("=")||Ñ.Length<8);bool ç=false;foreach(var Ñ in æ){var è
=Ñ.Split('=');if(!ǻ.ContainsKey(è[0])){MyDefinitionId H;if(MyDefinitionId.TryParse(ǥ+è[0],out H)){Ï(H);ç=true;}}ǻ[è[0]]=è
[1];}if(ç)Ø();List<string>é=new List<string>{"Special Container modes:","",
"Positive number: stores wanted amount, removes excess (e.g.: 100)","Negative number: doesn't store items, only removes excess (e.g.: -100)",
"Keyword 'all': stores all items of that subtype (like a type container)",""};foreach(var u in ǻ){é.Add(u.Key+"="+u.Value);}N.CustomData=string.Join("\n",é);}void ê(){ɤ.Clear();ɤ.AddRange(ǰ);ɤ.
AddRange(Ǳ);ɤ.AddRange(ǲ);ɤ.AddRange(ǳ);ɤ.AddRange(ǵ);ǻ.Clear();foreach(var u in ǰ){ǻ[ǧ+"/"+u]="0";}foreach(var u in Ǯ){ǻ[ȇ+"/"+
u]="0";}foreach(var u in ǯ){ǻ[Ǧ+"/"+u]="0";}foreach(var u in Ǳ){ǻ[Ǩ+"/"+u]="0";}foreach(var u in ǲ){ǻ[ǩ+"/"+u]="0";}
foreach(var u in ǳ){ǻ[Ǫ+"/"+u]="0";}foreach(var u in ǵ){ǻ[ǫ+"/"+u]="0";}}void Í(){for(int X=ɻ;X<Ȳ.Count;X++){if(ƻ())return;if(ɻ
>=Ȳ.Count-1){ɻ=0;}else{ɻ++;}var Æ=new List<MyInventoryItem>();Ȳ[X].GetInventory(0).GetItems(Æ);foreach(var u in Æ){
MyDefinitionId H=u.Type;if(ǭ.Contains(H))continue;string É=H.TypeId.ToString().Replace(ǥ,"");string Ë=H.SubtypeId.ToString();ɜ=
"Found new item!\n"+Ë+" ("+É+")";if(É==ȇ){Ǯ.Add(Ë);Ƌ(Ë);if(!Ë.Contains("Ice")){foreach(var Î in Ⱥ){if(Î.GetInventory(0).CanItemsBeAdded(1,H
)){ɘ.Add(Ë);break;}}}}else if(É==Ǧ){ǯ.Add(Ë);}else if(É==ǧ){ǰ.Add(Ë);}else if(É==Ǩ){Ǳ.Add(Ë);}else if(É==ǩ){ǲ.Add(Ë);}
else if(É==Ǫ){ǳ.Add(Ë);}else if(É==ǫ){ǵ.Add(Ë);}Ï(H);Ɩ(H);}}}void Ï(MyDefinitionId H){Ô();if(Me.CustomData.Contains(H.
ToString()))return;var Ð=Me.CustomData.Split('\n').ToList();for(int X=Ð.Count-1;X>=0;X--){if(Ð[X].Contains(";")){Ð.Insert(X+1,H+
";noBP");break;}}Me.CustomData=String.Join("\n",Ð);ǂ(H);}bool Ø(){Ô();var Ð=Me.CustomData.Split('\n');GridTerminalSystem.
GetBlocksOfType(ɝ);foreach(var Ñ in Ð){var Ò=Ñ.Split(';');if(Ò.Length<2)continue;MyDefinitionId H;if(!MyDefinitionId.TryParse(Ò[0],out
H))continue;MyDefinitionId Ó;if(MyDefinitionId.TryParse(Ò[1],out Ó)){if(ɝ.Count==0)return false;if(ƕ(Ó)){ǁ(H,Ó);}else{Ɲ(H
);continue;}}string É=H.TypeId.ToString().Replace(ǥ,"");string Ë=H.SubtypeId.ToString();if(É==ȇ){Ǯ.Add(Ë);Ƌ(Ë);if(!Ë.
Contains("Ice")){foreach(var Î in Ⱥ){if(Î.GetInventory(0).CanItemsBeAdded(1,H)){ɘ.Add(Ë);break;}}}}else if(É==Ǧ){ǯ.Add(Ë);}else
if(É==ǧ){ǰ.Add(Ë);}else if(É==Ǩ){Ǳ.Add(Ë);}else if(É==ǩ){ǲ.Add(Ë);}else if(É==Ǫ){ǳ.Add(Ë);}else if(É==ǫ){ǵ.Add(Ë);}ǂ(H);}
return true;}void Ô(){if(!Me.CustomData.Contains(ɐ)){Me.CustomData=(Ǽ?ǽ:Ǿ)+ɐ;}}void Õ(){if(ɕ!=null){var Æ=new List<
MyInventoryItem>();ɕ.GetInventory(1).GetItems(Æ);var Ö=new List<MyProductionItem>();ɕ.GetQueue(Ö);if(Æ.Count==0)return;ɕ.CustomName=ɖ;
MyDefinitionId Ó=Ö[0].BlueprintId;MyDefinitionId H=Æ[0].Type;if(Æ.Count==1&&Ö.Count==1&&ɕ.Mode==MyAssemblerMode.Assembly&&Ó==ɗ){if(ɖ.
Contains(learnKeyword)&&!ɖ.Contains(learnManyKeyword))ɕ.CustomName=ɖ.Replace(" "+learnKeyword,"").Replace(learnKeyword+" ","");ɕ
.ClearQueue();ɕ=null;ɗ=new MyDefinitionId();ɜ="Learned new Blueprint!\n'"+Ó.ToString().Replace(ǥ,"")+"'\nproduces: '"+H.
ToString().Replace(ǥ,"")+"'";ǁ(H,Ó);ƛ(H,Ó);return;}else if(Ö.Count!=1){ƞ(
"Blueprint learning aborted!\nExactly 1 itemstack in the queue is needed to learn new recipes!");}}ɕ=null;ɗ=new MyDefinitionId();foreach(var Ā in ɟ){var Ö=new List<MyProductionItem>();Ā.GetQueue(Ö);if(Ö.Count==1&&Ā.
Mode==MyAssemblerMode.Assembly){MyDefinitionId Ó=Ö[0].BlueprintId;if(Ā.GetInventory(1).ItemCount!=0){IMyTerminalBlock Á=O(Ā,
ɨ);if(Á!=null){Ê("",Ā,1,Á,0);}else{ƞ("Can't learn blueprint!\nNo free containers to clear the output inventory found!");
return;}}ɕ=Ā;ɗ=Ó;ɖ=Ā.CustomName;Ā.CustomName="Learning "+Ó.SubtypeName+" in: "+Ā.CustomName;return;}}}bool ƕ(MyDefinitionId Ó)
{try{foreach(var Ā in ɝ){if(Ā.CanUseBlueprint(Ó))return true;}}catch{return false;}return false;}void Ɩ(MyDefinitionId H)
{if(ɝ.Count==0)return;if(H.TypeId.ToString()==ǥ+ȇ||H.TypeId.ToString()==ǥ+Ǧ)return;MyDefinitionId Ó;bool Ɠ=Ǹ.TryGetValue(
H,out Ó);if(Ɠ)Ɠ=ƕ(Ó);if(!Ɠ){var Ɨ=new List<string>{"BP","","Component","Magazine","_Blueprint"};bool Ƙ=false;foreach(var
ƙ in Ɨ){string ƚ=Ǭ+H.SubtypeId.ToString().Replace("Item","")+ƙ;MyDefinitionId.TryParse(ƚ,out Ó);Ƙ=ƕ(Ó);if(Ƙ){ǁ(H,Ó);ƛ(H,Ó
);Ɠ=true;return;}}}}void ƛ(MyDefinitionId H,MyDefinitionId Ó){Ô();var Ð=Me.CustomData.Split('\n');for(var X=0;X<Ð.Length;
X++){if(!Ð[X].Contains(H.ToString()))continue;var Ò=Ð[X].Split(';');Ð[X]=Ò[0]+";"+Ó.ToString();Me.CustomData=String.Join(
"\n",Ð);return;}}void Ɲ(MyDefinitionId H){Ô();var Ð=Me.CustomData.Split('\n').ToList();Ð.RemoveAll(X=>X.Contains(H.ToString(
)));Me.CustomData=String.Join("\n",Ð);}void ƞ(string û){Ɉ.Add(û);ɉ.Add(û);Ĳ=Ɉ.ElementAt(0);}void Ɵ(){Me.CustomData="";
foreach(var N in ɭ){List<string>Ð=N.CustomData.Replace(" ","").TrimEnd('\n').Split('\n').ToList();Ð.RemoveAll(Ñ=>!Ñ.Contains(
"=")||Ñ.Contains("=0"));N.CustomData=string.Join("\n",Ð);}Echo("Stored items deleted!\n");if(ɭ.Count>0)Echo(
"Also deleted itemlists of "+ɭ.Count+" Special containers!\n");Echo("Please hit 'Recompile'!\n\nScript stopped!");}void Ơ(){Ȅ.Clear();List<
IMyTerminalBlock>ơ=ɞ.ToList<IMyTerminalBlock>();List<IMyTerminalBlock>Ƣ=ȱ.ToList<IMyTerminalBlock>();ƣ(Ȳ,0);ƣ(ơ,1);ƣ(Ƣ,1);}void ƣ(List<
IMyTerminalBlock>Ɯ,int J){for(int X=0;X<Ɯ.Count;X++){var Æ=new List<MyInventoryItem>();Ɯ[X].GetInventory(J).GetItems(Æ);for(int Ɖ=0;Ɖ<Æ.
Count;Ɖ++){MyDefinitionId H=Æ[Ɖ].Type;if(Ȅ.ContainsKey(H)){Ȅ[H]+=(double)Æ[Ɖ].Amount;}else{Ȅ[H]=(double)Æ[Ɖ].Amount;}}}}
double G(MyDefinitionId H){double Ɗ;Ȅ.TryGetValue(H,out Ɗ);return Ɗ;}void Ƌ(string ƌ){if(!Ȱ.ContainsKey(ƌ)){Ȱ[ƌ]=0.5;}}double
ƍ(string ƌ){double Ɗ;ƌ=ƌ.Replace(ǥ+ȇ+"/","");Ȱ.TryGetValue(ƌ,out Ɗ);return Ɗ!=0?Ɗ:0.5;}void Ǝ(){Ƕ.Clear();foreach(
IMyAssembler Ā in ɝ){var Ö=new List<MyProductionItem>();Ā.GetQueue(Ö);if(Ö.Count>0&&!Ā.IsProducing){if(Ā.Mode==MyAssemblerMode.
Assembly)ƞ("'"+Ā.CustomName+"' has a queue but is currently not assembling!\nAre there enough ingots for the craft?");if(Ā.Mode
==MyAssemblerMode.Disassembly)ƞ("'"+Ā.CustomName+
"' has a queue but is currently not disassembling!\nAre the items to disassemble missing?");}foreach(var u in Ö){MyDefinitionId Ó=u.BlueprintId;if(Ƕ.ContainsKey(Ó)){Ƕ[Ó]+=(double)u.Amount;}else{Ƕ[Ó]=(double)u.
Amount;}}}}double Ə(MyDefinitionId Ó){double Ɗ;Ƕ.TryGetValue(Ó,out Ɗ);return Ɗ;}void Ɛ(MyDefinitionId H,double w){Ƿ[H]=w;}
double Ƒ(MyDefinitionId Ó){double Ɗ;if(!Ƿ.TryGetValue(Ó,out Ɗ))Ɗ=100000;return Ɗ;}MyDefinitionId ƒ(MyDefinitionId H,out bool Ɠ
){MyDefinitionId Ó;Ɠ=Ǹ.TryGetValue(H,out Ó);return Ó;}MyDefinitionId Ɣ(MyDefinitionId Ó){MyDefinitionId H;ǹ.TryGetValue(Ó
,out H);return H;}bool Ƥ(MyDefinitionId Ó){return ǹ.ContainsKey(Ó);}void ǁ(MyDefinitionId H,MyDefinitionId Ó){Ǹ[H]=Ó;ǹ[Ó]
=H;}void ǂ(MyDefinitionId H){ǭ.Add(H);Ǻ[H.SubtypeId.ToString()]=H;}MyDefinitionId ǃ(string Ë){MyDefinitionId H=new
MyDefinitionId();Ǻ.TryGetValue(Ë,out H);return H;}StringBuilder Ǆ(IMyTextSurface e,string v,double Û,double ǅ,string ǆ=null,string Ǉ=
null,bool m=false,bool ǈ=false){string ö=Û.ToString();string ø=ǅ.ToString();if(ǆ!=null){ö=ǆ;}if(Ǉ!=null){ø=Ǉ;}float ş=e.
FontSize;float ŵ=e.Ń();char ǉ=' ';float Ǌ=e.Ļ(ǉ);StringBuilder ǋ=new StringBuilder(" "+Û.Ű(ǅ));ǋ=e.ń(ǉ,e.Š("99999.9%")-e.Š(ǋ)).
Append(ǋ);StringBuilder ǌ=new StringBuilder(ö+" / "+ø);StringBuilder Ǎ=new StringBuilder(v+" ");StringBuilder ǎ=new
StringBuilder();StringBuilder Ǐ;double ǀ=0;if(ǅ>0)ǀ=Û/ǅ>=1?1:Û/ǅ;if(ǈ&&!m){if(ş<=0.5||(ş<=1&&ŵ>512)){Ǐ=e.ń(ǉ,ŵ*0.4-e.Š(Ǎ)-e.Š(ö+" /")
);Ǎ.Append(Ǐ).Append(ǌ);Ǐ=e.ń(ǉ,ŵ*0.6-e.Š(Ǎ));Ǎ.Append(Ǐ);Ǎ.Append(ǐ(e,ŵ-e.Š(Ǎ)-e.Š(ǋ),ǀ));Ǎ.Append(ǋ);}else{Ǐ=e.ń(ǉ,ŵ*
0.5-e.Š(Ǎ));Ǎ.Append(Ǐ);Ǎ.Append(ǐ(e,ŵ-e.Š(Ǎ)-e.Š(ǋ),ǀ));Ǎ.Append(ǋ);}}else{if(ş<=0.6||(ş<=1&&ŵ>512)){Ǐ=e.ń(ǉ,ŵ*0.5-e.Š(Ǎ)-
e.Š(ö+" /"));Ǎ.Append(Ǐ).Append(ǌ);Ǐ=e.ń(ǉ,ŵ-e.Š(Ǎ)-e.Š(ǋ));Ǎ.Append(Ǐ).Append(ǋ);if(!m){ǎ=ǐ(e,ŵ,ǀ).Append("\n");}}else{Ǐ
=e.ń(ǉ,ŵ-e.Š(Ǎ)-e.Š(ǌ));Ǎ.Append(Ǐ).Append(ǌ);if(!m){ǎ=ǐ(e,ŵ-e.Š(ǋ),ǀ);ǎ.Append(ǋ).Append("\n");}}}return Ǎ.Append("\n").
Append(ǎ);}StringBuilder ǐ(IMyTextSurface e,float Ş,double ǀ){StringBuilder Ƴ,ƥ;char Ʀ='[';char Ƨ=']';char ƨ='I';char Ʃ='.';
float ƪ=e.Ļ(Ʀ);float ƫ=e.Ļ(Ƨ);float Ƭ=Ş-ƪ-ƫ;Ƴ=e.ń(ƨ,Ƭ*ǀ);ƥ=e.ń(Ʃ,Ƭ-e.Š(Ƴ));return new StringBuilder().Append(Ʀ).Append(Ƴ).
Append(ƥ).Append(Ƨ);}StringBuilder ƭ=new StringBuilder("No performance Information available!");Dictionary<string,int>Ʈ=new
Dictionary<string,int>();List<int>Ư=new List<int>(new int[100]);List<double>ư=new List<double>(new double[100]);double Ʊ,Ʋ;int ƴ=0
;DateTime ƾ;void Ƶ(string ƶ,bool Ƅ=false){if(Ƅ){ƾ=DateTime.Now;return;}ƴ=ƴ>=99?0:ƴ+1;int Ʒ=Runtime.
CurrentInstructionCount;if(Ʒ>Ʊ)Ʊ=Ʒ;Ư[ƴ]=Ʒ;double Ƹ=Ư.Sum()/Ư.Count;ƭ.Clear();ƭ.Append("Instructions: "+Ʒ+" / "+Runtime.MaxInstructionCount+"\n"
);ƭ.Append("Max. Instructions: "+Ʊ+" / "+Runtime.MaxInstructionCount+"\n");ƭ.Append("Avg. Instructions: "+Math.Floor(Ƹ)+
" / "+Runtime.MaxInstructionCount+"\n\n");double ƹ=(DateTime.Now-ƾ).TotalMilliseconds;if(ƹ>Ʋ&&Ʈ.ContainsKey(ƶ))Ʋ=ƹ;ư[ƴ]=ƹ;
double ƺ=ư.Sum()/ư.Count;ƭ.Append("Last runtime: "+Math.Round(ƹ,4)+" ms\n");ƭ.Append("Max. runtime: "+Math.Round(Ʋ,4)+" ms\n")
;ƭ.Append("Avg. runtime: "+Math.Round(ƺ,4)+" ms\n\n");ƭ.Append("Instructions per Method:\n");Ʈ[ƶ]=Ʒ;foreach(var u in Ʈ.
OrderByDescending(X=>X.Value)){ƭ.Append("- "+u.Key+": "+u.Value+"\n");}ƭ.Append("\n");}bool ƻ(double Û=10){return Runtime.
CurrentInstructionCount>Û*1000;}List<IMyTerminalBlock>Ƽ(string Ƈ,string[]ƽ=null){string ƿ="[IsyLCD]";var ƈ=new List<IMyTerminalBlock>();
GridTerminalSystem.GetBlocksOfType<IMyTextSurfaceProvider>(ƈ,ŏ=>ŏ.IsSameConstructAs(Me)&&(ŏ.CustomName.Contains(Ƈ)||(ŏ.CustomName.Contains
(ƿ)&&ŏ.CustomData.Contains(Ƈ))));var ţ=ƈ.FindAll(ŏ=>ŏ.CustomName.Contains(Ƈ));foreach(var e in ţ){e.CustomName=e.
CustomName.Replace(Ƈ,"").Replace(" "+Ƈ,"").TrimEnd(' ');bool Ő=false;if(e is IMyTextSurface){if(!e.CustomName.Contains(ƿ))Ő=true;
if(!e.CustomData.Contains(Ƈ))e.CustomData="@0 "+Ƈ+(ƽ!=null?"\n"+String.Join("\n",ƽ):"");}else if(e is
IMyTextSurfaceProvider){if(!e.CustomName.Contains(ƿ))Ő=true;int ő=(e as IMyTextSurfaceProvider).SurfaceCount;for(int X=0;X<ő;X++){if(!e.
CustomData.Contains("@"+X)){e.CustomData+=(e.CustomData==""?"":"\n\n")+"@"+X+" "+Ƈ+(ƽ!=null?"\n"+String.Join("\n",ƽ):"");break;}}}
else{ƈ.Remove(e);}if(Ő)e.CustomName+=" "+ƿ;}return ƈ;}
}class Œ:IComparer<MyDefinitionId>{public int Compare(MyDefinitionId œ,MyDefinitionId Ŕ){return œ.ToString().CompareTo(Ŕ.
ToString());}}class ŕ:IEqualityComparer<MyInventoryItem>{public bool Equals(MyInventoryItem œ,MyInventoryItem Ŕ){return œ.
ToString()==Ŕ.ToString();}public int GetHashCode(MyInventoryItem u){return u.ToString().GetHashCode();}}public static partial
class Ŗ{private static Dictionary<char,float>ŗ=new Dictionary<char,float>();public static void ř(string š,float Ś){foreach(
char ś in š){ŗ[ś]=Ś;}}public static void Ŝ(){if(ŗ.Count>0)return;ř(
"3FKTabdeghknopqsuy£µÝàáâãäåèéêëðñòóôõöøùúûüýþÿāăąďđēĕėęěĝğġģĥħĶķńņňŉōŏőśŝşšŢŤŦũūŭůűųŶŷŸșȚЎЗКЛбдекруцяёђћўџ",18);ř("ABDNOQRSÀÁÂÃÄÅÐÑÒÓÔÕÖØĂĄĎĐŃŅŇŌŎŐŔŖŘŚŜŞŠȘЅЊЖф□",22);ř("#0245689CXZ¤¥ÇßĆĈĊČŹŻŽƒЁЌАБВДИЙПРСТУХЬ€",20);ř(
"￥$&GHPUVY§ÙÚÛÜÞĀĜĞĠĢĤĦŨŪŬŮŰŲОФЦЪЯжы†‡",21);ř("！ !I`ijl ¡¨¯´¸ÌÍÎÏìíîïĨĩĪīĮįİıĵĺļľłˆˇ˘˙˚˛˜˝ІЇії‹›∙",9);ř("？7?Jcz¢¿çćĉċčĴźżžЃЈЧавийнопсъьѓѕќ",17);ř(
"（）：《》，。、；【】(),.1:;[]ft{}·ţťŧț",10);ř("+<=>E^~¬±¶ÈÉÊË×÷ĒĔĖĘĚЄЏЕНЭ−",19);ř("L_vx«»ĹĻĽĿŁГгзлхчҐ–•",16);ř("\"-rª­ºŀŕŗř",11);ř("WÆŒŴ—…‰",32);ř("'|¦ˉ‘’‚",7)
;ř("@©®мшњ",26);ř("mw¼ŵЮщ",28);ř("/ĳтэє",15);ř("\\°“”„",13);ř("*²³¹",12);ř("¾æœЉ",29);ř("%ĲЫ",25);ř("MМШ",27);ř("½Щ",30);
ř("ю",24);ř("ј",8);ř("љ",23);ř("ґ",14);ř("™",31);}public static Vector2 ŝ(this IMyTextSurface þ,StringBuilder û){Ŝ();
Vector2 Ş=new Vector2();if(þ.Font=="Monospace"){float ş=þ.FontSize;Ş.X=(float)(û.Length*19.4*ş);Ş.Y=(float)(28.8*ş);return Ş;}
else{float ş=(float)(þ.FontSize*0.779);foreach(char ś in û.ToString()){try{Ş.X+=ŗ[ś]*ş;}catch{}}Ş.Y=(float)(28.8*þ.FontSize)
;return Ş;}}public static float Š(this IMyTextSurface e,StringBuilder û){Vector2 ł=e.ŝ(û);return ł.X;}public static float
Š(this IMyTextSurface e,string û){Vector2 ł=e.ŝ(new StringBuilder(û));return ł.X;}public static float Ļ(this
IMyTextSurface e,char ļ){float Ľ=Š(e,new string(ļ,1));return Ľ;}public static int ľ(this IMyTextSurface e){Vector2 Ŀ=e.SurfaceSize;
float ŀ=e.TextureSize.Y;Ŀ.Y*=512/ŀ;float Ł=Ŀ.Y*(100-e.TextPadding*2)/100;Vector2 ł=e.ŝ(new StringBuilder("T"));return(int)(Ł/
ł.Y);}public static float Ń(this IMyTextSurface e){Vector2 Ŀ=e.SurfaceSize;float ŀ=e.TextureSize.Y;Ŀ.X*=512/ŀ;return Ŀ.X*
(100-e.TextPadding*2)/100;}public static StringBuilder ń(this IMyTextSurface e,char Ņ,double ņ){int Ň=(int)(ņ/Ļ(e,Ņ));if(
Ň<0)Ň=0;return new StringBuilder().Append(Ņ,Ň);}private static DateTime ň=DateTime.Now;private static Dictionary<int,List
<int>>ŉ=new Dictionary<int,List<int>>();public static StringBuilder Ŋ(this IMyTextSurface e,StringBuilder û,int ŋ=3,bool
ĝ=true,int ħ=0){int Ō=e.GetHashCode();if(!ŉ.ContainsKey(Ō)){ŉ[Ō]=new List<int>{1,3,ŋ,0};}int ō=ŉ[Ō][0];int Ř=ŉ[Ō][1];int
Ŏ=ŉ[Ō][2];int Ţ=ŉ[Ō][3];var Ŵ=û.ToString().TrimEnd('\n').Split('\n');List<string>Ĥ=new List<string>();if(ħ==0)ħ=e.ľ();
float ŵ=e.Ń();StringBuilder ñ,ĭ=new StringBuilder();for(int X=0;X<Ŵ.Length;X++){if(X<ŋ||X<Ŏ||Ĥ.Count-Ŏ>ħ||e.Š(Ŵ[X])<=ŵ){Ĥ.Add
(Ŵ[X]);}else{try{ĭ.Clear();float Ŷ,ŷ;var Ÿ=Ŵ[X].Split(' ');string Ź=System.Text.RegularExpressions.Regex.Match(Ŵ[X],
@"\d+(\.|\:)\ ").Value;ñ=e.ń(' ',e.Š(Ź));foreach(var ź in Ÿ){Ŷ=e.Š(ĭ);ŷ=e.Š(ź);if(Ŷ+ŷ>ŵ){Ĥ.Add(ĭ.ToString());ĭ=new StringBuilder(ñ+ź+
" ");}else{ĭ.Append(ź+" ");}}Ĥ.Add(ĭ.ToString());}catch{Ĥ.Add(Ŵ[X]);}}}if(ĝ){if(Ĥ.Count>ħ){if(DateTime.Now.Second!=Ţ){Ţ=
DateTime.Now.Second;if(Ř>0)Ř--;if(Ř<=0)Ŏ+=ō;if(Ŏ+ħ-ŋ>=Ĥ.Count&&Ř<=0){ō=-1;Ř=3;}if(Ŏ<=ŋ&&Ř<=0){ō=1;Ř=3;}}}else{Ŏ=ŋ;ō=1;Ř=3;}ŉ[Ō][
0]=ō;ŉ[Ō][1]=Ř;ŉ[Ō][2]=Ŏ;ŉ[Ō][3]=Ţ;}else{Ŏ=ŋ;}StringBuilder Ż=new StringBuilder();for(var Ñ=0;Ñ<ŋ;Ñ++){Ż.Append(Ĥ[Ñ]+"\n"
);}for(var Ñ=Ŏ;Ñ<Ĥ.Count;Ñ++){Ż.Append(Ĥ[Ñ]+"\n");}return Ż;}public static Dictionary<IMyTextSurface,string>ż(this
IMyTerminalBlock I,string Ƈ,Dictionary<string,string>ž=null){var ſ=new Dictionary<IMyTextSurface,string>();if(I is IMyTextSurface){ſ[I
as IMyTextSurface]=I.CustomData;}else if(I is IMyTextSurfaceProvider){var ƀ=System.Text.RegularExpressions.Regex.Matches(I
.CustomData,@"@(\d) *("+Ƈ+@")");int Ɓ=(I as IMyTextSurfaceProvider).SurfaceCount;foreach(System.Text.RegularExpressions.
Match Ƃ in ƀ){int ƃ=-1;if(int.TryParse(Ƃ.Groups[1].Value,out ƃ)){if(ƃ>=Ɓ)continue;string Ð=I.CustomData;int Ƅ=Ð.IndexOf("@"+ƃ
);int ƅ=Ð.IndexOf("@"+(ƃ+1))-Ƅ;string ÿ=ƅ<=0?Ð.Substring(Ƅ):Ð.Substring(Ƅ,ƅ);ſ[(I as IMyTextSurfaceProvider).GetSurface(ƃ
)]=ÿ;}}}return ſ;}public static bool Ɔ(this string ÿ,string ß){var Ð=ÿ.Replace(" ","").Split('\n');foreach(var Ñ in Ð){if
(Ñ.StartsWith(ß+"=")){try{return Convert.ToBoolean(Ñ.Replace(ß+"=",""));}catch{return true;}}}return true;}public static
string Ž(this string ÿ,string ß){var Ð=ÿ.Replace(" ","").Split('\n');foreach(var Ñ in Ð){if(Ñ.StartsWith(ß+"=")){return Ñ.
Replace(ß+"=","");}}return"";}}public static partial class Ŗ{public static bool Ť(this double Û,double ť,double ø,bool Ŧ=false,
bool ŧ=false){bool Ũ=ŧ?Û>ť:Û>=ť;bool ũ=Ŧ?Û<ø:Û<=ø;return Ũ&&ũ;}}public static partial class Ŗ{public static string Ū(this
char ū,int Ŭ){if(Ŭ<=0){return"";}return new string(ū,Ŭ);}}public static partial class Ŗ{public static string ŭ(this double Û
){string Ů="kL";if(Û<1){Û*=1000;Ů="L";}else if(Û>=1000&&Û<1000000){Û/=1000;Ů="ML";}else if(Û>=1000000&&Û<1000000000){Û/=
1000000;Ů="BL";}else if(Û>=1000000000){Û/=1000000000;Ů="TL";}return Math.Round(Û,1)+" "+Ů;}}public static partial class Ŗ{
public static string ů(this double Û){string Ů="";if(Û>=1000&&Û<1000000){Û/=1000;Ů=" k";}else if(Û>=1000000&&Û<1000000000){Û/=
1000000;Ů=" M";}else if(Û>=1000000000){Û/=1000000000;Ů=" B";}return Math.Round(Û,1)+Ů;}}public static partial class Ŗ{public
static string Ű(this double ű,double Ų){double ų=Math.Round(ű/Ų*100,1);if(Ų==0){return"0%";}else{return ų+"%";}}public static
string Ű(this float ű,float Ų){double ų=Math.Round(ű/Ų*100,1);if(Ų==0){return"0%";}else{return ų+"%";}}