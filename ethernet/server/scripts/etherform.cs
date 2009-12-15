//------------------------------------------------------------------------------
// Revenge Of The Cats: Ethernet
// Copyright (C) 2009, mEthLab Interactive
//------------------------------------------------------------------------------

exec("./etherform.sfx.cs");
exec("./etherform.gfx.cs");

//-----------------------------------------------------------------------------

function EtherformData::useWeapon(%this, %obj, %nr)
{
	if(%nr < 1 || %nr > 3)
		return;

	%client = %obj.client;

	if(%nr == 1)
		%client.mainWeapon = $MainWeapon::AssaultRifle;
	else if(%nr == 2)
		%client.mainWeapon = $MainWeapon::SniperRifle;
	else if(%nr == 3)
		%client.mainWeapon = $MainWeapon::MissileLauncher;
		
	messageClient(%client, 'MsgWeaponUsed', "", %client.mainWeapon);
}

function EtherformData::damage(%this, %obj, %sourceObject, %pos, %damage, %damageType)
{
	// ignore damage
}

function EtherformData::onAdd(%this, %obj)
{
	Parent::onAdd(%this, %obj);
	
	// start singing...
	%obj.playAudio(1, EtherformSingSound);
}

function EtherformData::onDamage(%this, %obj, %delta)
{
	// don't do anything
}

//-----------------------------------------------------------------------------

datablock EtherformData(RedEtherform)
{
	hudImageNameFriendly = "~/client/ui/hud/pixmaps/teammate.etherform.png";
	hudImageNameEnemy = "~/client/ui/hud/pixmaps/enemy.etherform.png";
	
	thirdPersonOnly = true;

    //category = "Vehicles"; don't appear in mission editor
	shapeFile = "~/data/vehicles/etherform/vehicle.red.dts";
	emap = true;
 
	cameraDefaultFov = 110.0;
	cameraMinFov     = 110.0;
	cameraMaxFov     = 130.0;
	cameraMinDist    = 2;
	cameraMaxDist    = 3;
	
	//renderWhenDestroyed = false;
	//explosion = FlyerExplosion;
	//defunctEffect = FlyerDefunctEffect;
	//debris = BomberDebris;
	//debrisShapeName = "~/data/vehicles/bomber/vehicle.dts";

	mass = 90;
	drag = 0.99;
	density = 10;

	maxDamage = 75;
	damageBuffer = 25;
	maxEnergy = 100;

	damageBufferRechargeRate = 0.15;
	damageBufferDischargeRate = 0.05;
	energyRechargeRate = 0.4;
 
    // collision box...
    boundingBox = "1.0 1.0 1.0";
 
    // etherform movement...
    accelerationForce = 100;

	// impact damage...
	minImpactSpeed = 1;		// If hit ground at speed above this then it's an impact. Meters/second
	speedDamageScale = 0.0;	// Dynamic field: impact damage multiplier

	// damage info eyecandy...
	damageBufferParticleEmitter = RedEtherformDamageBufferEmitter;
	repairParticleEmitter = RedEtherformRepairEmitter;
	bufferRepairParticleEmitter = RedEtherformBufferRepairEmitter;

	// laser trail...
	laserTrail[0] = RedEtherform_LaserTrailOne;
	laserTrail[1] = RedEtherform_LaserTrailTwo;

	// contrail...
//	minTrailSpeed = 150;		// The speed your contrail shows up at
//	trailEmitter = RedEtherform_ContrailEmitter;
	
	// various emitters...
	//forwardJetEmitter = FlyerJetEmitter;
	//downJetEmitter = FlyerJetEmitter;

	//
//	jetSound = Team1ScoutFlyerThrustSound;
//	engineSound = EtherformSound;
	softImpactSound = EtherformImpactSound;
	hardImpactSound = EtherformImpactSound;
	//wheelImpactSound = WheelImpactSound;


};

datablock EtherformData(BlueEtherform : RedEtherform)
{
	shapeFile = "~/data/vehicles/etherform/vehicle.blue.dts";
	damageBufferParticleEmitter = BlueEtherformDamageBufferEmitter;
	repairParticleEmitter = BlueEtherformRepairEmitter;
	bufferRepairParticleEmitter = BlueEtherformBufferRepairEmitter;
	laserTrail[0] = BlueEtherform_LaserTrailOne;
	laserTrail[1] = BlueEtherform_LaserTrailTwo;
	//trailEmitter = BlueEtherform_ContrailEmitter;
};


