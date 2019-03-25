Login-AzureRmAccount

$subId = Read-Host -Prompt "Type in SubscriptionId for which you want to remove resources"
Select-AzureRmSubscription -SubscriptionId $subId

$resourceGroupName = Read-Host -Prompt "Enter the Resource Group name"
$resourceTypes = Read-Host -Prompt "Enter the Resource Types, separated by comma"

if (!$resourceTypes){ # if types were not passed, then by default remove Sql Databases and web apps
	$resourceTypes = 'Microsoft.Sql/Servers/Databases,Microsoft.web/sites'
}

$resourceTypes = $resourceTypes.Split("{,}");

ForEach ($item in $resourceTypes){
	Remove-AzureRmResource -ResourceType $item -ResourceGroupName $resourceGroupName
}