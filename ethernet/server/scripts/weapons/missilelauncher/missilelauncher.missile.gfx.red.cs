//------------------------------------------------------------------------------
// Revenge Of The Cats: Ethernet
// Copyright (C) 2009, mEthLab Interactive
//------------------------------------------------------------------------------

//------------------------------------------------------------------------------
// Revenge Of The Cats - missilelauncher.gfx.red.cs
// Eye-candy for the missile launcher
//------------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// laser trail

datablock MultiNodeLaserBeamData(RedMissileLauncherMissileTrail)
{
	//bitmap = "~/data/weapons/missilelauncher/lasertrail_red";
	bitmapWidth = 0.50;

	blendMode = 1;
	fadeTime = 1000;
};


//-----------------------------------------------------------------------------
// laser tail

datablock LaserBeamData(RedMissileLauncherMissileTail)
{
	hasLine = true;
	lineStartColor	= "1.00 0.00 1.00 0.0";
	lineBetweenColor = "1.00 0.00 1.00 0.5";
	lineEndColor	  = "1.00 0.00 1.00 0.5";
    lineWidth = 2.0;

	hasInner = true;
	innerStartColor	= "1.00 0.00 1.00 0.0";
	innerBetweenColor = "1.00 0.00 1.00 0.5";
	innerEndColor	  = "1.00 0.00 1.00 0.5";
	innerStartWidth	= "0.0";
	innerBetweenWidth = "0.3";
	innerEndWidth	  = "0.1";

	hasOuter = true;
	outerStartColor	= "1.00 0.00 1.00 0.0";
	outerBetweenColor = "1.00 0.00 1.00 0.5";
	outerEndColor	  = "1.00 0.00 1.00 0.5";
	outerStartWidth	= "0.1";
	outerBetweenWidth = "0.4";
	outerEndWidth	  = "0.2";

//	crossBitmap = "~/data/projectiles/team1heavyrepeater/lasertail_cross";
//	crossBitmapWidth = 2;

	betweenFactor = 0.999;
	blendMode = 1;
};

//-----------------------------------------------------------------------------
// slow projectile particle emitter

datablock ParticleData(RedSlowMissileLauncherMissileEmitter_Particles)
{
	dragCoeffiecient	  = 0.4;
	gravityCoefficient	= -0.5;	// rises slowly
	inheritedVelFactor	= 0.025;

	lifetimeMS			  = 1250;
	lifetimeVarianceMS	= 0;

	useInvAlpha =  true;
	spinRandomMin = -200.0;
	spinRandomMax =  200.0;

	textureName = "~/data/particles/smoke_particle.png";

	colors[0]	  = "0.9 0.9 0.9 0.4";
	colors[1]	  = "0.9 0.9 0.9 0.2";
	colors[2]	  = "0.9 0.9 0.9 0.0";
	sizes[0]		= 1.0;
	sizes[1]		= 1.0;
	sizes[2]		= 1.0;
	times[0]		= 0.0;
	times[1]		= 0.5;
	times[2]		= 1.0;

	allowLighting = true;
};

datablock ParticleEmitterData(RedSlowMissileLauncherMissileEmitter)
{
	ejectionPeriodMS = 50;
	periodVarianceMS = 0;
	ejectionVelocity = 2.0;
	velocityVariance = 0.0;
	ejectionOffset	= 0.0;
	thetaMin			= 45;
	thetaMax			= 45;
	phiReferenceVel  = 75000;
	phiVariance		= 0;
	overrideAdvances = false;
	orientParticles  = false;
	lifetimeMS		 = 0;
	particles = "RedSlowMissileLauncherMissileEmitter_Particles";
};

//-----------------------------------------------------------------------------
// projectile particle emitter

datablock ParticleData(RedMissileLauncherMissileEmitter_Particles)
{
	dragCoeffiecient    = 0.4;
	gravityCoefficient	= -0.5;	// rises slowly
	inheritedVelFactor	= 0.0;

	lifetimeMS         = 2500;
	lifetimeVarianceMS = 0;

	useInvAlpha =  true;
	spinRandomMin = -200.0;
	spinRandomMax =  200.0;

	textureName = "~/data/particles/smoke_particle.png";

	colors[0]	  = "0.9 0.9 0.9 0.8";
	colors[1]	  = "0.9 0.9 0.9 0.4";
	colors[2]	  = "0.9 0.9 0.9 0.0";
	sizes[0]		= 1.0;
	sizes[1]		= 1.5;
	sizes[2]		= 2.0;
	times[0]		= 0.0;
	times[1]		= 0.5;
	times[2]		= 1.0;

	allowLighting = true;
};

datablock ParticleEmitterData(RedMissileLauncherMissileEmitter)
{
	ejectionPeriodMS = 10;
	periodVarianceMS = 3;
	ejectionVelocity = 0.0;
	velocityVariance = 0.0;
	ejectionOffset	= 0.0;
	thetaMin		= 0;
	thetaMax		= 10;
	phiReferenceVel  = 360;
	phiVariance		= 0;
	overrideAdvances = false;
	orientParticles  = false;
	lifetimeMS		 = 0;
	particles = "RedMissileLauncherMissileEmitter_Particles";
};

//-----------------------------------------------------------------------------
// fire particle emitter

datablock ParticleData(RedMissileLauncherFireEmitter_Particles)
{
	dragCoefficient		= 1;
	gravityCoefficient	= -0.5;
	windCoefficient		= 0.0;
	inheritedVelFactor	= 0.2;
	constantAcceleration = 0.0;
	lifetimeMS			  = 200;
	lifetimeVarianceMS	= 0;
	textureName			 = "~/data/particles/smoke_particle";
	colors[0]	  = "1.0 1.0 1.0 1.0";
	colors[1]	  = "1.0 0.0 0.0 1.0";
	colors[2]	  = "1.0 0.0 0.0 0.0";
	sizes[0]		= 1.0;
	sizes[1]		= 0.5;
	sizes[2]		= 0.0;
	times[0]		= 0.0;
	times[1]		= 0.5;
	times[2]		= 1.0;

};

datablock ParticleEmitterData(RedMissileLauncherFireEmitter)
{
	ejectionPeriodMS = 10;
	periodVarianceMS = 0;
	ejectionVelocity = 15.0;
	velocityVariance = 0.2;
	ejectionOffset	= 0;
	thetaMin			= 0;
	thetaMax			= 10;
	phiReferenceVel  = 0;
	phiVariance		= 90;
	overrideAdvances = false;
	orientParticles  = false;
	lifetimeMS		 = 0;
	particles = "RedMissileLauncherFireEmitter_Particles";
};

//-----------------------------------------------------------------------------
// near enemy explosion

datablock ParticleData( RedMissileLauncherNearEnemyExplosionDebrisSmokeParticle )
{
	dragCoeffiecient	  = 1.0;
	gravityCoefficient	= 0.0;
	windCoefficient		= 0.2;
	inheritedVelFactor	= 0.0;

	lifetimeMS			  = 400;
	lifetimeVarianceMS	= 0;

	textureName			 = "~/data/particles/small_particle4";

	//spinRandomMin = -60.0;
	//spinRandomMax = 60.0;

	colors[0]	  = "1.0 0.0 1.0 0.25";
	colors[1]	  = "1.0 0.0 0.0 0.25";
	colors[2]	  = "1.0 1.0 0.0 0.25";
	colors[3]	  = "0.0 5.0 0.0 0.0";
	sizes[0]		= 1.0;
	sizes[1]		= 1.0;
	sizes[2]		= 1.0;
	sizes[3]		= 1.0;
	times[0]		= 0.0;
	times[1]		= 0.333;
	times[2]		= 0.666;
	times[3]		= 1.0;
};

datablock ParticleEmitterData( RedMissileLauncherNearEnemyExplosionDebrisSmokeEmitter )
{
	ejectionPeriodMS = 10;
	periodVarianceMS = 1;

	ejectionVelocity = 0.0;
	velocityVariance = 0.0;

	thetaMin			= 0.0;
	thetaMax			= 0.0;

	particles = "RedMissileLauncherNearEnemyExplosionDebrisSmokeParticle";
};


datablock DebrisData( RedMissileLauncherNearEnemyExplosionDebris )
{
	emitters[0] = RedMissileLauncherNearEnemyExplosionDebrisSmokeEmitter;

	explodeOnMaxBounce = true;

	elasticity = 0.4;
	friction = 0.2;

	lifetime = 0.15;
	lifetimeVariance = 0.02;

	baseRadius = 0.0;

	numBounces = 1;
};

datablock ParticleData(RedMissileLauncherNearEnemyExplosionCloud)
{
	dragCoefficient		= 1;
	gravityCoefficient	= -0.15; // rise slowly
	inheritedVelFactor	= 0.2;
	constantAcceleration = 0.0;
	lifetimeMS			  = 500;
	lifetimeVarianceMS	= 350;
	spinRandomMin = -200.0;
	spinRandomMax =  200.0;
	textureName			 = "~/data/particles/particle1";
	colors[0]	  = "1.00 1.00 1.00 0.8";
	colors[1]	  = "1.00 0.00 0.00 0.4";
	colors[2]	  = "1.00 0.00 0.00 0.0";
	sizes[0]		= 5.0;
	sizes[1]		= 2.0;
	sizes[2]		= 0.5;
	times[0]		= 0.0;
	times[1]		= 0.2;
	times[2]		= 1.0;

};

datablock ParticleEmitterData(RedMissileLauncherNearEnemyExplosionCloudEmitter)
{
	ejectionPeriodMS = 4;
	periodVarianceMS = 0;
	ejectionVelocity = 1;
	velocityVariance = 0;
	ejectionOffset	= 0;
	thetaMin			= 0;
	thetaMax			= 180;
	phiReferenceVel  = 0;
	phiVariance		= 360;
	overrideAdvances = false;
	orientParticles  = false;
	lifetimeMS		 = 100;
	particles = "RedMissileLauncherNearEnemyExplosionCloud";
};

datablock ExplosionData(RedMissileLauncherNearEnemyExplosion)
{
	soundProfile	= MissileLauncherNearEnemyExplosionSound;

	faceViewer	  = true;
	explosionScale = "1.0 1.0 1.0";
	
	debris = RedMissileLauncherNearEnemyExplosionDebris;
	debrisThetaMin = 0;
	debrisThetaMax = 180;
	debrisNum = 15;
	debrisVelocity = 30.0;
	debrisVelocityVariance = 0.0;

	//emitter[0] = RedMissileLauncherNearEnemyExplosionCloudEmitter;

	shakeCamera = true;
	camShakeFreq = "10.0 6.0 9.0";
	camShakeAmp = "20.0 20.0 20.0";
	camShakeDuration = 0.5;
	camShakeRadius = 20.0;
};

//-----------------------------------------------------------------------------
// explosion

datablock ParticleData(RedMissileLauncherMissileExplosion_Cloud)
{
	dragCoeffiecient	  = 0.4;
	gravityCoefficient	= 0;
	inheritedVelFactor	= 0.025;

	lifetimeMS			  = 600;
	lifetimeVarianceMS	= 0;

	useInvAlpha =  false;
	spinRandomMin = -200.0;
	spinRandomMax =  200.0;

	textureName = "~/data/particles/corona.png";

	colors[0]	  = "1.0 1.0 1.0 1.0";
	colors[1]	  = "1.0 1.0 1.0 0.0";
	colors[2]	  = "1.0 1.0 1.0 0.0";
	sizes[0]		= 6.0;
	sizes[1]		= 6.0;
	sizes[2]		= 2.0;
	times[0]		= 0.0;
	times[1]		= 0.2;
	times[2]		= 1.0;

	allowLighting = true;
};

datablock ParticleEmitterData(RedMissileLauncherMissileExplosion_CloudEmitter)
{
	ejectionPeriodMS = 5;
	periodVarianceMS = 0;

	ejectionVelocity = 6.25;
	velocityVariance = 0.25;

	thetaMin			= 0.0;
	thetaMax			= 90.0;

	lifetimeMS		 = 100;

	particles = "RedMissileLauncherMissileExplosion_Cloud";
};

datablock ParticleData(RedMissileLauncherMissileExplosion_Dust)
{
	dragCoefficient		= 1.0;
	gravityCoefficient	= -0.01;
	inheritedVelFactor	= 0.0;
	constantAcceleration = 0.0;
	lifetimeMS			  = 1000;
	lifetimeVarianceMS	= 100;
	useInvAlpha			 = true;
	spinRandomMin		  = -90.0;
	spinRandomMax		  = 500.0;
	textureName			 = "~/data/particles/smoke_particle.png";
	colors[0]	  = "0.9 0.9 0.9 0.5";
	colors[1]	  = "0.9 0.9 0.9 0.5";
	colors[2]	  = "0.9 0.9 0.9 0.0";
	sizes[0]		= 3.2;
	sizes[1]		= 4.6;
	sizes[2]		= 5.0;
	times[0]		= 0.0;
	times[1]		= 0.7;
	times[2]		= 1.0;
	allowLighting = true;
};

datablock ParticleEmitterData(RedMissileLauncherMissileExplosion_DustEmitter)
{
	ejectionPeriodMS = 5;
	periodVarianceMS = 0;
	ejectionVelocity = 15.0;
	velocityVariance = 0.0;
	ejectionOffset	= 0.0;
	thetaMin			= 90;
	thetaMax			= 90;
	phiReferenceVel  = 0;
	phiVariance		= 360;
	overrideAdvances = false;
	lifetimeMS		 = 250;
	particles = "RedMissileLauncherMissileExplosion_Dust";
};


datablock ParticleData(RedMissileLauncherMissileExplosion_Smoke)
{
	dragCoeffiecient	  = 0.4;
	gravityCoefficient	= -0.5;	// rises slowly
	inheritedVelFactor	= 0.025;

	lifetimeMS			  = 1250;
	lifetimeVarianceMS	= 0;

	useInvAlpha =  true;
	spinRandomMin = -200.0;
	spinRandomMax =  200.0;

	textureName = "~/data/particles/smoke_particle.png";

	colors[0]	  = "0.9 0.9 0.9 0.4";
	colors[1]	  = "0.9 0.9 0.9 0.2";
	colors[2]	  = "0.9 0.9 0.9 0.0";
	sizes[0]		= 2.0;
	sizes[1]		= 6.0;
	sizes[2]		= 2.0;
	times[0]		= 0.0;
	times[1]		= 0.5;
	times[2]		= 1.0;

	allowLighting = true;
};

datablock ParticleEmitterData(RedMissileLauncherMissileExplosion_SmokeEmitter)
{
	ejectionPeriodMS = 5;
	periodVarianceMS = 0;

	ejectionVelocity = 6.25;
	velocityVariance = 0.25;

	thetaMin			= 0.0;
	thetaMax			= 180.0;

	lifetimeMS		 = 250;

	particles = "RedMissileLauncherMissileExplosion_Smoke";
};

datablock ParticleData(RedMissileLauncherMissileExplosion_Sparks)
{
	dragCoefficient		= 1;
	gravityCoefficient	= 0.0;
	inheritedVelFactor	= 0.2;
	constantAcceleration = 0.0;
	lifetimeMS			  = 500;
	lifetimeVarianceMS	= 350;
	textureName			 = "~/data/particles/particle1.png";
	colors[0]	  = "0.56 0.36 0.26 1.0";
	colors[1]	  = "0.56 0.36 0.26 1.0";
	colors[2]	  = "1.0 0.36 0.26 0.0";
	sizes[0]		= 0.5;
	sizes[1]		= 0.5;
	sizes[2]		= 0.75;
	times[0]		= 0.0;
	times[1]		= 0.5;
	times[2]		= 1.0;
	allowLighting = false;
};

datablock ParticleEmitterData(RedMissileLauncherMissileExplosion_SparksEmitter)
{
	ejectionPeriodMS = 2;
	periodVarianceMS = 0;
	ejectionVelocity = 12;
	velocityVariance = 6.75;
	ejectionOffset	= 0.0;
	thetaMin			= 0;
	thetaMax			= 60;
	phiReferenceVel  = 0;
	phiVariance		= 360;
	overrideAdvances = false;
	orientParticles  = true;
	lifetimeMS		 = 100;
	particles = "RedMissileLauncherMissileExplosion_Sparks";
};

datablock DebrisData(RedMissileLauncherMissileExplosion_SmallDebris)
{
	// shape...
	shapeFile = "~/data/misc/debris1.white.dts";

	// bounce...
	staticOnMaxBounce = true;
	numBounces = 5;

	// physics...
	gravModifier = 2.0;
	elasticity = 0.6;
	friction = 0.1;

	// spin...
	minSpinSpeed = 60;
	maxSpinSpeed = 600;

	// lifetime...
	lifetime = 2.0;
	lifetimeVariance = 1.0;
};

datablock MultiNodeLaserBeamData(RedMissileLauncherMissileExplosion_LargeDebris_LaserTrail)
{
	hasLine = true;
	lineColor	= "1.00 1.00 1.00 0.5";

	hasInner = false;
	innerColor = "1.00 1.00 0.00 0.3";
	innerWidth = "0.20";

	hasOuter = true;
	outerColor = "1.00 1.00 1.00 0.2";
	outerWidth = "0.40";

//	bitmap = "~/data/weapons/missilelauncher/explosion.trail";
//	bitmapWidth = 0.25;

	blendMode = 1;
	renderMode = $MultiNodeLaserBeamRenderMode::FaceViewer;
	fadeTime = 1000;
};

datablock ParticleData(RedMissileLauncherMissileExplosion_LargeDebris_Particles2)
{
	dragCoefficient		= 1;
	gravityCoefficient	= 0.0;
	windCoefficient		= 0.0;
	inheritedVelFactor	= 0.0;
	constantAcceleration = 0.0;
	lifetimeMS			  = 1000;
	lifetimeVarianceMS	= 0;
	textureName			 = "~/data/particles/cross1";
	colors[0]	  = "1.0 1.0 1.0 0.6";
	colors[1]	  = "1.0 1.0 1.0 0.4";
	colors[2]	  = "1.0 1.0 1.0 0.2";
	colors[3]	  = "1.0 1.0 1.0 0.0";
	sizes[0]		= 1.0;
	sizes[1]		= 1.0;
	sizes[2]		= 1.0;
	sizes[3]		= 1.0;
	times[0]		= 0.0;
	times[1]		= 0.333;
	times[2]		= 0.666;
	times[3]		= 1.0;
};

datablock ParticleEmitterData(RedMissileLauncherMissileExplosion_LargeDebris_Emitter2)
{
	ejectionPeriodMS = 30;
	periodVarianceMS = 0;
	ejectionVelocity = 2.0;
	velocityVariance = 0.0;
	ejectionOffset	= 0.0;
	thetaMin			= 45;
	thetaMax			= 45;
	phiReferenceVel  = 75000;
	phiVariance		= 0;
	overrideAdvances = false;
	orientParticles  = false;
	lifetimeMS		 = 0;
	particles = "RedMissileLauncherMissileExplosion_LargeDebris_Particles2";
};

datablock ParticleData(RedMissileLauncherMissileExplosion_LargeDebris_Particles1)
{
	dragCoefficient		= 1;
	gravityCoefficient	= 0.0;
	windCoefficient		= 0.0;
	inheritedVelFactor	= 0.0;
	constantAcceleration = 0.0;
	lifetimeMS			  = 100;
	lifetimeVarianceMS	= 0;
	textureName			 = "~/data/particles/cross1";
	colors[0]	  = "1.0 1.0 1.0 1.0";
	colors[1]	  = "1.0 1.0 1.0 1.0";
	colors[2]	  = "1.0 1.0 1.0 0.5";
	colors[3]	  = "1.0 1.0 1.0 0.0";
	sizes[0]		= 2.0;
	sizes[1]		= 2.0;
	sizes[2]		= 2.0;
	sizes[3]		= 2.0;
	times[0]		= 0.0;
	times[1]		= 0.333;
	times[2]		= 0.666;
	times[3]		= 1.0;
};

datablock ParticleEmitterData(RedMissileLauncherMissileExplosion_LargeDebris_Emitter1)
{
	ejectionPeriodMS = 5;
	periodVarianceMS = 0;
	ejectionVelocity = 10.0;
	velocityVariance = 0.0;
	ejectionOffset	= 0.0;
	thetaMin			= 0;
	thetaMax			= 180;
	phiReferenceVel  = 0;
	phiVariance		= 360;
	overrideAdvances = false;
	orientParticles  = false;
	lifetimeMS		 = 0;
	particles = "RedMissileLauncherMissileExplosion_LargeDebris_Particles1";
};

datablock ExplosionData(RedMissileLauncherMissileExplosion_LargeDebris_Explosion)
{
	soundProfile	= MissileLauncherDebrisSound;
	
	debris = RedMissileLauncherMissileExplosion_SmallDebris;
	debrisThetaMin = 0;
	debrisThetaMax = 60;
	debrisNum = 5;
	debrisVelocity = 15.0;
	debrisVelocityVariance = 10.0;
};

datablock DebrisData(RedMissileLauncherMissileExplosion_LargeDebris)
{
	// shape...
	shapeFile = "~/data/misc/debris2.white.dts";

	explosion = RedMissileLauncherMissileExplosion_LargeDebris_Explosion;

	//laserTrail = RedMissileLauncherMissileExplosion_LargeDebris_LaserTrail;
	emitters[0] = RedMissileLauncherMissileExplosion_LargeDebris_Emitter2;
	//emitters[1] = RedMissileLauncherMissileExplosion_LargeDebris_Emitter1;

	// bounce...
	numBounces = 0;
	explodeOnMaxBounce = true;

	// physics...
	gravModifier = 2.0;
	elasticity = 0.6;
	friction = 0.1;

	// spin...
	minSpinSpeed = 60;
	maxSpinSpeed = 600;

	// lifetime...
	lifetime = 20.0;
	lifetimeVariance = 0.0;
};

datablock ExplosionData(RedMissileLauncherMissileExplosion)
{
	soundProfile	= MissileLauncherExplosionSound;

	faceViewer	  = true;
	explosionScale = "0.8 0.8 0.8";
	
	lifetimeMS = 200;

	debris = RedMissileLauncherMissileExplosion_LargeDebris;
	debrisThetaMin = 0;
	debrisThetaMax = 60;
	debrisNum = 5;
	debrisVelocity = 30.0;
	debrisVelocityVariance = 10.0;

	particleEmitter = RedMissileLauncherMissileExplosion_CloudEmitter;
	particleDensity = 100;
	particleRadius = 4;

	emitter[0] = RedMissileLauncherMissileExplosion_DustEmitter;
	emitter[1] = RedMissileLauncherMissileExplosion_SmokeEmitter;
	emitter[2] = RedMissileLauncherMissileExplosion_SparksEmitter;

	// Camera shake
	shakeCamera = true;
	camShakeFreq = "10.0 6.0 9.0";
	camShakeAmp = "20.0 20.0 20.0";
	camShakeDuration = 0.5;
	camShakeRadius = 20.0;
	
	// Dynamic light
	lightStartRadius = 3;
	lightEndRadius = 20;
	lightStartColor = "1.0 1.0 0.0";
	lightEndColor = "0.0 0.0 0.0";
};


