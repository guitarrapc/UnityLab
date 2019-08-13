# UPM ec2 set by CloudFormation

## CloudFormation

Use Cloud Formation Template `verdaccio_cloudformation-ec2-efs.yaml` which fix official https://verdaccio.org/docs/en/amazon cloudformation template failed ec2 launch on second time image up.

Key | Value | note
---- | ---- | ----
Ami| ami-0c3fd0f5d33134a76 | amazon linux2
AsgInstanceType| t3.nano | cheapest
DnsHostedZoneName| guitarrapc.com | your domain
DnsName| upm | your subdomain
Ec2KeyPair| upm | your ec2key
HttpsCertificateArn| arn:aws:acm:ap-northeast-1:AWSACCOUNT:certificate/ARN | your ACM's arn
Route53RecordHostedZoneId| Z14GRHDCWA56QT | Elastic Load Balancing's HostedZoneId: ap-norhteast-1

## Upm

Package Manage user registration.

login: https://upm.guitarrapc.com/#/

now your credential is written in ~/.npmrc

```shell
npm set registry https://upm.guitarrapc.com
npm adduser --registry https://upm.guitarrapc.com
```

prepare package.json for your unity module and publish.

```
npm publish --registry https://upm.guitarrapc.com
```

Go to Unity project and open Packages/manifest.json to register your registry.

Add package registry to scopedRegistries in Unity `Packages/manifest.json`.

```json
{
  "scopedRegistries": [
    {
      "name": "upm.guitarrapc.com",
      "url": "https://upm.guitarrapc.com",
      "scopes": [
        "com.guitarrapc"
      ]
    }
  ],
  "dependencies": {
    "com.unity.ads": "2.0.8",
    "com.unity.analytics": "3.3.2",
    "com.unity.collab-proxy": "1.2.16",
    "com.unity.package-manager-ui": "2.1.2",
    "com.unity.purchasing": "2.0.6",
    "com.unity.textmeshpro": "2.0.1",
    "com.unity.timeline": "1.0.0",
    "com.unity.modules.ai": "1.0.0",
    "com.unity.modules.animation": "1.0.0",
    "com.unity.modules.assetbundle": "1.0.0",
    "com.unity.modules.audio": "1.0.0",
    "com.unity.modules.cloth": "1.0.0",
    "com.unity.modules.director": "1.0.0",
    "com.unity.modules.imageconversion": "1.0.0",
    "com.unity.modules.imgui": "1.0.0",
    "com.unity.modules.jsonserialize": "1.0.0",
    "com.unity.modules.particlesystem": "1.0.0",
    "com.unity.modules.physics": "1.0.0",
    "com.unity.modules.physics2d": "1.0.0",
    "com.unity.modules.screencapture": "1.0.0",
    "com.unity.modules.terrain": "1.0.0",
    "com.unity.modules.terrainphysics": "1.0.0",
    "com.unity.modules.tilemap": "1.0.0",
    "com.unity.modules.ui": "1.0.0",
    "com.unity.modules.uielements": "1.0.0",
    "com.unity.modules.umbra": "1.0.0",
    "com.unity.modules.unityanalytics": "1.0.0",
    "com.unity.modules.unitywebrequest": "1.0.0",
    "com.unity.modules.unitywebrequestassetbundle": "1.0.0",
    "com.unity.modules.unitywebrequestaudio": "1.0.0",
    "com.unity.modules.unitywebrequesttexture": "1.0.0",
    "com.unity.modules.unitywebrequestwww": "1.0.0",
    "com.unity.modules.vehicles": "1.0.0",
    "com.unity.modules.video": "1.0.0",
    "com.unity.modules.vr": "1.0.0",
    "com.unity.modules.wind": "1.0.0",
    "com.unity.modules.xr": "1.0.0"
  }
}
```

You will find Package from Unity > Windows > Package Manager.
