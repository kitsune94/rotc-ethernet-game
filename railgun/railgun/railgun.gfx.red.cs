//------------------------------------------------------------------------------
// Revenge Of The Cats: Ethernet
// Copyright (C) 2009, mEthLab Interactive
//------------------------------------------------------------------------------

//------------------------------------------------------------------------------
// Revenge Of The Cats - railgun.gfx.red.cs
// Eyecandy for the railgun
//------------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// laser trail

datablock MultiNodeLaserBeamData(RedRailgunProjectileLaserTrailOne)
{
	hasLine = false;
	lineColor	= "1.00 1.00 1.00 1.0";

	hasInner = false;
	innerColor = "0.00 1.00 0.00 1.00";
	innerWidth = "0.05";

	hasOuter = true;
	outerColor = "1.00 0.00 0.00 1.0";
	outerWidth = "0.05";

//	bitmap = "ethernet/data/weapons/assaultrifle/lasertrail";
//	bitmapWidth = 0.25;

	blendMode = 1;

    windCoefficient = 0.0;

    // node x movement...
    nodeMoveMode[0]     = $NodeMoveMode::DynamicSpeed;
    nodeMoveSpeed[0]    = -15;
    nodeMoveSpeedAdd[0] =  30;
    // node y movement...
    nodeMoveMode[1]     = $NodeMoveMode::DynamicSpeed;
    nodeMoveSpeed[1]    =  -15;
    nodeMoveSpeedAdd[1] =  30;
    // node z movement...
    nodeMoveMode[2]     = $NodeMoveMode::DynamicSpeed;
    nodeMoveSpeed[2]    = -15;
    nodeMoveSpeedAdd[2] = 30;

    nodeDistance = 1;

	fadeTime = 300;
};

datablock MultiNodeLaserBeamData(RedRailgunProjectileLaserTrailTwo)
{
	hasLine = false;
	lineColor	= "1.00 1.00 1.00 1.0";

	hasInner = false;
	innerColor = "0.00 1.00 0.00 1.00";
	innerWidth = "0.05";

	hasOuter = true;
	outerColor = "1.00 0.40 0.00 1.0";
	outerWidth = "0.05";

//	bitmap = "ethernet/data/weapons/assaultrifle/lasertrail";
//	bitmapWidth = 0.25;

	blendMode = 1;

    windCoefficient = 0.0;

    // node x movement...
    nodeMoveMode[0]     = $NodeMoveMode::DynamicSpeed;
    nodeMoveSpeed[0]    = -15;
    nodeMoveSpeedAdd[0] =  30;
    // node y movement...
    nodeMoveMode[1]     = $NodeMoveMode::DynamicSpeed;
    nodeMoveSpeed[1]    =  -15;
    nodeMoveSpeedAdd[1] =  30;
    // node z movement...
    nodeMoveMode[2]     = $NodeMoveMode::DynamicSpeed;
    nodeMoveSpeed[2]    = -15;
    nodeMoveSpeedAdd[2] = 30;

    nodeDistance = 1;

	fadeTime = 300;
};

datablock MultiNodeLaserBeamData(RedRailgunProjectileLaserTrailThree)
{
	hasLine = false;
	lineColor	= "1.00 1.00 1.00 1.0";

	hasInner = false;
	innerColor = "0.00 1.00 0.00 1.00";
	innerWidth = "0.05";

	hasOuter = true;
	outerColor = "1.00 0.80 0.00 1.0";
	outerWidth = "0.05";

//	bitmap = "ethernet/data/weapons/assaultrifle/lasertrail";
//	bitmapWidth = 0.25;

	blendMode = 1;

    windCoefficient = 0.0;

    // node x movement...
    nodeMoveMode[0]     = $NodeMoveMode::DynamicSpeed;
    nodeMoveSpeed[0]    = -15;
    nodeMoveSpeedAdd[0] =  30;
    // node y movement...
    nodeMoveMode[1]     = $NodeMoveMode::DynamicSpeed;
    nodeMoveSpeed[1]    =  -15;
    nodeMoveSpeedAdd[1] =  30;
    // node z movement...
    nodeMoveMode[2]     = $NodeMoveMode::DynamicSpeed;
    nodeMoveSpeed[2]    = -15;
    nodeMoveSpeedAdd[2] = 30;

    nodeDistance = 1;

	fadeTime = 300;
};

//-----------------------------------------------------------------------------
// projectile particle emitter

datablock ParticleData(RedRailgunProjectileParticleEmitter_Particles)
{
	dragCoefficient      = 1;
	gravityCoefficient   = 0.0;
	windCoefficient      = 0.0;
	inheritedVelFactor	 = 0.0;
	constantAcceleration = 0.0;
	lifetimeMS			 = 125;
	lifetimeVarianceMS	 = 0;
	spinRandomMin        = -1000.0;
	spinRandomMax        = 1000.0;
	textureName			 = "ethernet/data/particles/smoke_particle";
	colors[0]	    = "1.0 0.2 0.0 0.75";
	colors[1]	    = "1.0 0.2 0.0 0.0";
	sizes[0]		= 1.5;
	sizes[1]		= 1.5;
	times[0]		= 0.0;
	times[1]		= 1.0;
	useInvAlpha = false;
	renderDot = false;
};

datablock ParticleEmitterData(RedRailgunProjectileParticleEmitter)
{
	ejectionPeriodMS = 5;
	periodVarianceMS = 0;
	ejectionVelocity = 5.0;
	velocityVariance = 5.0;
	ejectionOffset	 = 0.0;
	thetaMin		 = 0;
	thetaMax		 = 0;
	phiReferenceVel  = 0;
	phiVariance		 = 360;
	overrideAdvances = false;
	orientParticles  = false;
	lifetimeMS		 = 0;
	particles = "RedRailgunProjectileParticleEmitter_Particles";
};

//-----------------------------------------------------------------------------
// explosion

datablock ParticleData(RedRailgunExplosion_Emitter_Particle)
{
	dragCoefficient		= 0.0;
	gravityCoefficient	= 0.0;
	inheritedVelFactor	= 0.0;
	constantAcceleration = 0.0;
	lifetimeMS			  = 500;
	lifetimeVarianceMS	= 0;
	colors[0]	  = "1.0 0.2 0.0 1.0";
	colors[1]	  = "1.0 0.2 0.0 1.0";
	colors[2]	  = "1.0 0.2 0.0 0.0";
	sizes[0]		= 3.0;
	sizes[1]		= 2.0;
	sizes[2]		= 0.0;
	times[0]		= 0.0;
	times[1]		= 0.5;
	times[2]		= 1.0;
	spinRandomMin = 0.0;
	spinRandomMax = 0.0;
	textureName	= "ethernet/data/particles/smoke_particle";
	allowLighting = false;
};

datablock ParticleEmitterData(RedRailgunExplosion_Emitter)
{
	ejectionPeriodMS = 2;
	periodVarianceMS = 0;
	ejectionVelocity = 10.0;
	velocityVariance = 4.0;
	ejectionOffset	 = 1.0;
	thetaMin			= 0;
	thetaMax			= 180;
	phiReferenceVel  = 0;
	phiVariance		= 360;
	overrideAdvance  = false;
	orientParticles  = false;
	lifetimeMS		 = 100;
	particles = RedRailgunExplosion_Emitter_Particle;
};

datablock ExplosionData(RedRailgunProjectileExplosion)
{
	soundProfile = RailgunProjectileExplosionSound;

	lifetimeMS = 600;

 	// shape...
	explosionShape = "ethernet/data/effects/explosion4_red.dts";
	faceViewer	  = false;
	playSpeed = 3.0;
	sizes[0] = "0.1 0.1 0.1";
	sizes[1] = "0.5 0.5 0.5";
	times[0] = 0.0;
	times[1] = 1.0;

	emitter[0] = RedRailgunExplosion_Emitter;

	// Camera shake
	shakeCamera = false;
	camShakeFreq = "10.0 6.0 9.0";
	camShakeAmp = "20.0 20.0 20.0";
	camShakeDuration = 0.5;
	camShakeRadius = 20.0;

	// Dynamic light
	lightStartRadius = 1;
	lightEndRadius = 10;
	lightStartColor = "1.0 0.0 0.0";
	lightEndColor = "0.0 0.0 0.0";
};


//-----------------------------------------------------------------------------
// missed enemy...

datablock ExplosionData(RedRailgunProjectileMissedEnemyEffect)
{
	soundProfile = RailgunProjectileMissedEnemySound;
};
